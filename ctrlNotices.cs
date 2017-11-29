using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MongoDB.Driver;

namespace wfBiblio
{
    public partial class ctrlNotices : UserControl
    {
        public ctrlNotices()
        {
            InitializeComponent();
        }

        public void RemplirExemplaires(Notice notice)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("cote");
            dt.Columns.Add("code barre");
            dt.Columns.Add("localisation");
            dt.Columns.Add("commentaires");
            dt.Columns.Add("id");

            if (notice.exemplaires == null)
                notice.exemplaires = new List<Exemplaire>();
            foreach (Exemplaire ex in notice.exemplaires)
            {
                var row = dt.NewRow();
                row.ItemArray = new object[] { ex.cote, ex.codeBarre, ex.localisation, ex.commentaires, ex._id };
                dt.Rows.Add(row);
            }
            dgvExemplaires.DataSource = dt;
            dgvExemplaires.AutoResizeColumns();
        }

        public void SetNotice(Notice notice)
        {
            timer1.Stop();
            pictureBox1.Image = null;
            noticeBindingSource.Clear();
            dgvExemplaires.DataSource = null;

            if (notice != null)
            {
                noticeBindingSource.DataSource = new List<Notice>() { notice };
                noticeBindingSource.Position = 0;
                RemplirExemplaires(notice);
                timer1.Start();
            }
        }

        public Notice GetNotice()
        {
            if (noticeBindingSource.Count == 0)
                return null;

            noticeBindingSource.EndEdit();
            return ((List<Notice>)noticeBindingSource.DataSource)[0];
        }

        public void Enregistrer()
        {
            Notice notice = GetNotice();
            if (notice != null)
            {
                var coll = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
                coll.ReplaceOne(Builders<Notice>.Filter.Eq(a => a._id, notice._id), notice);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var notice = GetNotice();
            string search = notice.isbn;
            if (search.Length < 8)
                search = notice.titre;
            try
            {
                var req = HttpWebRequest.Create("https://www.googleapis.com/books/v1/volumes?q=" + WebUtility.UrlEncode(search));
                using (var resp = req.GetResponse())
                {
                    var results = new System.IO.StreamReader(resp.GetResponseStream()).ReadToEnd();
                    dynamic result = Newtonsoft.Json.Linq.JObject.Parse(results);
                    if (result.items.Count > 0)
                    {
                        string tmp = result.items[0].volumeInfo.imageLinks.smallThumbnail;
                        pictureBox1.Load(tmp);
                    }
                }
            }
            catch { }
        }

        private void btnAjouterExemplaire_Click(object sender, EventArgs e)
        {
            using (var frm = new frmrExemplaire())
            {
                frm.SetExemplaire(new Exemplaire() { _id = MongoDB.Bson.ObjectId.GenerateNewId() });
                if (frm.ShowDialog()== DialogResult.OK)
                {
                    Notice notice = GetNotice();
                    if (notice.exemplaires == null)
                        notice.exemplaires = new List<Exemplaire>();
                    notice.exemplaires.Add(frm.GetExemplaire());
                    RemplirExemplaires(notice);
                }
            }
        }

        private void btnSupprimerExeplaire_Click(object sender, EventArgs e)
        {
            if (dgvExemplaires.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Confirmez-vous la suppression de cet exemplaire?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    MongoDB.Bson.ObjectId id = MongoDB.Bson.ObjectId.Parse(dgvExemplaires.SelectedRows[0].Cells["id"].Value.ToString());
                    Notice notice = GetNotice();
                    if (notice.exemplaires == null)
                        notice.exemplaires = new List<Exemplaire>();
                    notice.exemplaires.Remove(notice.exemplaires.Find(a => a._id == id));
                    RemplirExemplaires(notice);
                }
            }
        }

        private void dgvExemplaires_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExemplaires.SelectedRows.Count > 0)
            {
                Notice notice = GetNotice();
                if (notice.exemplaires == null)
                    notice.exemplaires = new List<Exemplaire>();
                using (var frm = new frmrExemplaire())
                {
                    MongoDB.Bson.ObjectId id = MongoDB.Bson.ObjectId.Parse(dgvExemplaires.SelectedRows[0].Cells["id"].Value.ToString());
                    frm.SetExemplaire(notice.exemplaires.Find(a => a._id == id));
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        notice.exemplaires.Remove(notice.exemplaires.Find(a => a._id == id));
                        notice.exemplaires.Add(frm.GetExemplaire());
                        RemplirExemplaires(notice);
                    }
                }
            }
        }
    }
}
