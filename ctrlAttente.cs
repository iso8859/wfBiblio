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
        public static string A_TRAITER = "A traiter";
        public static string PAS_TROUVE = "Introuvable";
        public static string TROUVE = "Trouvé";
        public static string PLUSIEURS_REPONSES = "Plusieurs réponses";
        public static string DEJA_A_LINVENTAIRE = "Déjà à l'inventaire";
        public ctrlAttente()
        {
            InitializeComponent();
        }

        public void Init()
        {
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
            timer1.Start();
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
            row["Status"] = notice.indexes.GetValue("Status", A_TRAITER).AsString;
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
            Notice notice = new Notice() { isbn = isbn };
            m_db.GetCollection<Notice>("NoticeAttente").InsertOne(notice);
            AddOrUpdate(notice);
            timer1.Start();
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
                if (row["Status"].ToString() == A_TRAITER)
                {
                    notice = m_db.GetCollection<Notice>("NoticeAttente").Find(_ => _._id == (ObjectId)row["_id"]).FirstOrDefault();
                    break;
                }
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
                        var indexes = notice.indexes;
                        notice = results[0];
                        notice._id = id;
                        notice.indexes = indexes;
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
            else
                timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dgvAttente.Columns["_id"].Visible = false;
            dgvAttente.Sort(dgvAttente.Columns["_id"], ListSortDirection.Descending);
            dgvAttente.AutoResizeColumns();
            RunWorker();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAttente.Rows)
                row.Selected = true;
            ajoutDirectSansVérifierToolStripMenuItem_Click(null, null);
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvAttente.SelectedRows)
            {
                using (var frm = new frmAjouterNotice())
                {
                    frm.txtSearch.Text = row.Cells["ISBN"].Value.ToString();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        var db = new MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
                        ObjectId id = (ObjectId)row.Cells["_id"].Value;
                        Notice notice = db.GetCollection<Notice>("NoticeAttente").Find(_ => _._id == id).FirstOrDefault();
                        // Remplacer par l'id d'exemplaire crée manuellement
                        notice.exemplaires = frm.m_lastNotice.exemplaires;
                        IntegrerEmprunt(notice);
                        db.GetCollection<Notice>("NoticeAttente").DeleteOne(_ => _._id == id);
                        toDelete.Add(row);
                        AddLog($"Notice ajoutée {notice.isbn} => {notice.titre} - {notice.auteur}");
                    }
                }
            }
            foreach (DataGridViewRow row in toDelete)
                dgvAttente.Rows.Remove(row);
        }

        private void ajoutDirectSansVérifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvAttente.SelectedRows)
            {
                ObjectId id = (ObjectId)row.Cells["_id"].Value;
                var db = new MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
                Notice notice = db.GetCollection<Notice>("NoticeAttente").Find(_ => _._id == id).FirstOrDefault();
                // Regarder si la notice n'existe pas déjà
                Notice existing = db.GetCollection<Notice>("Notice").Find(_ => _.isbn == notice.isbn).FirstOrDefault();
                if (existing == null)
                {
                    IntegrerEmprunt(notice);
                    notice.indexes = null;
                    db.GetCollection<Notice>("Notice").InsertOne(notice);
                    db.GetCollection<Notice>("NoticeAttente").DeleteOne(_ => _._id == id);
                    toDelete.Add(row);
                    AddLog($"Notice ajoutée {notice.isbn} => {notice.titre} - {notice.auteur}");
                }
                else
                {
                    db.GetCollection<Notice>("NoticeAttente").DeleteOne(_ => _._id == id);
                    toDelete.Add(row);
                    AddLog($"Notice exite déjà, pas d'ajout {notice.isbn} => {notice.titre} - {notice.auteur}");
                }
            }
            foreach (DataGridViewRow row in toDelete)
                dgvAttente.Rows.Remove(row);
        }

        private void IntegrerEmprunt(Notice notice)
        {
            if (notice.indexes == null)
                notice.indexes = new BsonDocument();
            if (notice.indexes.Contains("ajouterLecteur"))
            {
                Emprunt emprunt = MongoDB.Bson.Serialization.BsonSerializer.Deserialize<Emprunt>(notice.indexes["ajouterLecteur"].AsBsonDocument);
                InfoLecteur lecteur = new MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<InfoLecteur>("InfoLecteur").Find(_ => _._id == emprunt.idLecteur).FirstOrDefault();
                var collEmprunt = new MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Emprunt>("Emprunt");
                if (notice.exemplaires != null && notice.exemplaires.Count > 0)
                {
                    emprunt.IdExemplaire = notice.exemplaires.FirstOrDefault()._id;
                    collEmprunt.InsertOne(emprunt);
                    AddLog($"Ajout de l'emprunt pour le lecteur {lecteur.nom} {lecteur.prénom} {notice.isbn} => {notice.titre} - {notice.auteur}");
                }
                else
                    AddLog($"Pas d'exemplaires, impossible d'enregistrer l'emprunt pour le lecteur {lecteur.nom} {lecteur.prénom} {notice.isbn} => {notice.titre} - {notice.auteur}");

            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvAttente.SelectedRows)
                toDelete.Add(row);
            foreach (DataGridViewRow row in toDelete)
                dgvAttente.Rows.Remove(row);
        }
    }
}
