using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
namespace wfBiblio
{
    public partial class ctrlAttente : UserControl
    {
        IMongoDatabase m_db;
        DataTable m_dt;
        string A_TRAITER = "A traiter";
        string PAS_TROUVE = "Introuvable";
        string TROUVE = "Trouvé";
        string PLUSIEURS_REPONSES = "Plusieurs réponses";
        string DEJA_A_LINVENTAIRE = "Déjà à l'inventaire";
        public ctrlAttente()
        {
            InitializeComponent();
            m_db = new MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            m_dt = new DataTable();
            m_dt.Columns.Add("_id", typeof(ObjectId));
            m_dt.Columns.Add("ISBN");
            m_dt.Columns.Add("Status");
            m_dt.Columns.Add("Titre");
            m_dt.Columns.Add("Auteur");
            dgvAttente.DataSource = m_dt;
            foreach (Notice notice in m_db.GetCollection<Notice>("NoticeAttente").Find(_ => true).ToList())
                AddOrUpdate(notice);
        }

        DataRow FindRow(ObjectId id)
        {
            foreach (DataRow row in m_dt.Rows)
            {
                if ((ObjectId)row["_id"] == id)
                    return row;
            }
            return null;
        }

        void AddOrUpdate(Notice notice)
        {
            DataRow row = FindRow(notice._id);
            if (row == null)
            {
                row = m_dt.NewRow();
                m_dt.Rows.Add(row);
            }
            row["_id"] = notice._id;
            row["ISBN"] = notice.isbn;
            if (notice.indexes == null)
                notice.indexes = new BsonDocument();
            row["Status"]= notice.indexes.GetValue("Status", A_TRAITER).AsString;
            row["Titre"] = notice.titre;
            row["Auteur"] = notice.auteur;
        }

        void AddLog(string message)
        {
            Invoke((MethodInvoker)delegate
            {
                txtLog.Text = DateTime.Now.ToString("HH:mm:ss - ") + message + "\r\n" + txtLog.Text;
                if (txtLog.Text.Length > 10000)
                    txtLog.Text = txtLog.Text.Substring(0, 10000);
            });
        }
        void AddIsbn(string isbn)
        {
            var db = new MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            Notice notice = new Notice() { isbn = isbn };
            m_db.GetCollection<Notice>("NoticeAttente").InsertOne(notice);
            AddOrUpdate(notice);
            RunWorker();
        }

        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtISBN.Text.Length > 0)
            {
                AddIsbn(txtISBN.Text);
                txtISBN.Text = "";
                txtISBN.Focus();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {

        }

        private void RunWorker()
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var db = new MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            // Trouver le premier record vide
            Notice notice = null;
            foreach (DataRow row in m_dt.Rows)
            {
                if (row["Status"].ToString()==A_TRAITER)
                    notice = m_db.GetCollection<Notice>("NoticeAttente").Find(_=>_._id == (ObjectId)row["_id"]).FirstOrDefault();
            }
            if (notice != null)
            {
                // Déjà à l'inventaire ?
                var notice2 = db.GetCollection<Notice>("Notice").Find(_ => _.isbn == notice.isbn).FirstOrDefault();
                if (notice2 != null)
                {
                    // Vérifier que nous ayons au moins un exemplaire
                    if (notice2.exemplaires == null)
                        notice2.exemplaires = new List<Exemplaire>();
                    if (notice2.exemplaires.Count == 0 || notice2.exemplaires.Find(_ => _.codeBarre == notice.isbn) == null)
                    {
                        notice2.exemplaires.Add(new Exemplaire()
                        {
                            _id = MongoDB.Bson.ObjectId.GenerateNewId(),
                            localisation = Properties.Settings.Default.Localisation,
                            codeBarre = notice.isbn,
                            dtCreation = DateTime.Now.ToUniversalTime()
                        });
                        // Ajouter dans la base immédiatement
                        db.GetCollection<Notice>("Notice").FindOneAndReplace(_ => _._id == notice2._id, notice2);
                        AddLog($"La notice {notice.isbn}/{notice2.titre} était déjà dans la base mais sans cet exemplaires, l'exemplaire est ajouté");
                    }
                    else
                        AddLog($"La notice {notice.isbn}/{notice2.titre} est déjà dans la base");
                    notice.titre = notice2.titre;
                    notice.auteur = notice2.auteur;
                    notice.indexes["Status"] = DEJA_A_LINVENTAIRE;
                }
                else
                {
                    if (notice.indexes == null)
                        notice.indexes = new BsonDocument();
                    var results = consoleBnf.query.NoticeQuery.GetNotice2(consoleBnf.query.QueryFilter.Isbn, consoleBnf.query.QueryFilterType.All, notice.isbn.Replace("-", "")).ToList();
                    if (results.Count == 1)
                    {
                        var id = notice._id;
                        notice = results[0];
                        notice._id = id;
                        if (notice.indexes == null)
                            notice.indexes = new BsonDocument();
                        if (notice.exemplaires == null)
                            notice.exemplaires = new List<Exemplaire>();
                        notice.exemplaires.Add(new Exemplaire()
                        {
                            _id = MongoDB.Bson.ObjectId.GenerateNewId(),
                            localisation = Properties.Settings.Default.Localisation,
                            codeBarre = notice.isbn,
                            dtCreation = DateTime.Now.ToUniversalTime()
                        });
                        notice.indexes["Status"] = TROUVE;
                        AddLog($"Notice trouvée pour {notice.isbn} => {notice.titre} - {notice.auteur}");
                    }
                    else if (results.Count > 1)
                    {
                        notice.indexes["Status"] = PLUSIEURS_REPONSES;
                        AddLog($"Plusieurs réponses pour {notice.isbn}");
                    }
                    else
                    {
                        notice.indexes["Status"] = PAS_TROUVE;
                        AddLog($"Notice introuvable pour {notice.isbn}");
                    }
                }
                AddOrUpdate(notice);
                db.GetCollection<Notice>("NoticeAttente").FindOneAndReplace(_ => _._id == notice._id, notice);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvAttente.Columns["_id"].Visible = false;
            dgvAttente.Sort(dgvAttente.Columns["_id"], ListSortDirection.Descending);
            dgvAttente.AutoResizeColumns();
            RunWorker();
        }
    }
}
