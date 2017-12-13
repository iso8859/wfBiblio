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
    public partial class frmResultSearch : Form
    {
        internal int m_notice;

        public frmResultSearch()
        {
            InitializeComponent();
        }

        internal void Init(List<Notice> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Titre");
            dt.Columns.Add("Auteur");
            dt.Columns.Add("Editeur");
            dt.Columns.Add("Année");
            foreach (Notice n in list)
            {
                var row = dt.NewRow();
                row.ItemArray = new object[] { n.titre, n.auteur, n.éditeur, n.année };
                dt.Rows.Add(row);
            }
            dgvNotices.DataSource = dt;
            timer1.Start();
        }

        private void dgvNotices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotices.SelectedRows.Count > 0)
            {
                m_notice = dgvNotices.SelectedRows[0].Index;
                DialogResult = DialogResult.OK;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            dgvNotices.AutoResizeRows();
            dgvNotices.AutoResizeColumns();
        }
    }
}
