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
    public partial class frmAjouterNotice : Form
    {
        public frmAjouterNotice()
        {
            InitializeComponent();
        }

        private void frmAjouterNotice_Load(object sender, EventArgs e)
        {
            ctrlNotices1.SetNotice(new Notice() { _id = MongoDB.Bson.ObjectId.GenerateNewId() });
        }

        private void GestionAjout(List<Notice> list)
        {
            if (list == null || list.Count == 0)
                MessageBox.Show("Pas de réponse");
            else if (list.Count == 1)
                ctrlNotices1.SetNotice(list[0]);
            else
            {
                using (frmResultSearch frs = new frmResultSearch())
                {
                    frs.Init(list);
                    if (frs.ShowDialog() == DialogResult.OK)
                        ctrlNotices1.SetNotice(list[frs.m_notice]);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GestionAjout(consoleBnf.query.NoticeQuery.GetNotice2(consoleBnf.query.QueryFilter.Isbn, consoleBnf.query.QueryFilterType.All, txtSearch.Text.Replace("-", "")).ToList());
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            GestionAjout(consoleBnf.query.NoticeQuery.GetNotice2(consoleBnf.query.QueryFilter.Anywhere, consoleBnf.query.QueryFilterType.Any, txtSearch2.Text).ToList());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ctrlNotices1.Enregistrer();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
