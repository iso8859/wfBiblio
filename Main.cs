using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfBiblio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtNotice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchNotices_Click(sender, null);
        }

        private void btnSearchNotices_Click(object sender, EventArgs e)
        {
            var coll = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            dgvResultNotice.DataSource = null;
            var cursor = coll.Find(
                Builders<Notice>.Filter.Or(
                    Builders<Notice>.Filter.Regex(a => a.auteur, new MongoDB.Bson.BsonRegularExpression(txtNotice.Text, "/i")),
                    Builders<Notice>.Filter.Regex(a => a.titre, new MongoDB.Bson.BsonRegularExpression(txtNotice.Text, "/i"))
                    )
                );
            if (cursor != null)
                dgvResultNotice.DataSource = cursor.ToList();

            dgvResultNotice.AutoResizeColumns();
            txtNotice.SelectAll();
        }

        private void dgvResultNotice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResultNotice.SelectedRows.Count > 0)
                ctrlNotices1.SetNotice(((List<Notice>)dgvResultNotice.DataSource)[dgvResultNotice.SelectedRows[0].Index]);
            else
                ctrlNotices1.SetNotice(null);
        }

        private void btnAddNotice_Click(object sender, EventArgs e)
        {
            using (var imp = new ImportNoticeExemplaires())
                imp.ShowDialog();
        }

        private void btnEnregistrerNotice_Click(object sender, EventArgs e)
        {
            Notice notice = ctrlNotices1.GetNotice();
            if (notice != null)
            {
                var coll = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
                coll.ReplaceOne(Builders<Notice>.Filter.Eq(a => a._id, notice._id), notice);
            }
        }
    }
}
