using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace wfBiblio
{
    public partial class ctrlCorriger : UserControl
    {
        public ctrlCorriger()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var coll = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            List<Notice> tmp = new List<Notice>();
            foreach (Notice notice in coll.Find(_ => true).ToList())
            {
                bool add = false;
                if (notice.exemplaires == null || notice.exemplaires.Count == 0 || string.IsNullOrWhiteSpace(notice.titre))
                    add = true;
                if (notice.exemplaires != null)
                {
                    foreach (var ex in notice.exemplaires)
                        if (string.IsNullOrWhiteSpace(ex.codeBarre))
                            add = true;
                }
                if (add)
                    tmp.Add(notice);
            }
            dgvNotices.DataSource = tmp;
            dgvNotices.AutoResizeColumns();
        }

        private void dgvNotices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count > 0)
                ctrlNotices1.SetNotice(((List<Notice>)dgvNotices.DataSource)[dgvNotices.SelectedRows[0].Index]);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvNotices.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Confirmez-vous la suppression ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    var coll = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
                    Notice notice = ((List<Notice>)dgvNotices.DataSource)[dgvNotices.SelectedRows[0].Index];
                    coll.DeleteOne(Builders<Notice>.Filter.Eq(a => a._id, notice._id));
                    btnSearch_Click(null, null);
                }
            }
        }
    }
}
