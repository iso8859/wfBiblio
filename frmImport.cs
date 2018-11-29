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
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        List<string> m_colDest = new List<string>() { "Ignorer", "Nom", "Prénom" };
        private void frmImport_Load(object sender, EventArgs e)
        {
            colDestination.DataSource = m_colDest;
        }

        private void btnStep2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            // Détecter le séparateur de colonne
            using (System.IO.StringReader sr = new System.IO.StringReader(txtInput.Text))
            {
                string line = sr.ReadLine();
                var separator = Parsing.GetHeaderSeparator(line);
                var items = Parsing.SmartSplit(line, separator);
                for (int i = 0; i < items.Count; i++)
                    dgvSelection.Rows.Add(new object[] { $"Colonne {i + 1}", m_colDest[0], items[i] });
            }
        }

        private void btnStep3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
            // Trouver les colonnes nom/prénom
            int iNom = -1, iPrenom = -1;
            int idx = 0;
            foreach(DataGridViewRow row in dgvSelection.Rows)
            {
                if (row.Cells[colDestination.Index].Value.ToString() == m_colDest[1])
                    iNom = idx;
                if (row.Cells[colDestination.Index].Value.ToString() == m_colDest[2])
                    iPrenom = idx;
                idx++;
            }

            if (iNom != -1 && iPrenom != -1)
            {
                dgvSelection.Rows.Clear();
                using (System.IO.StringReader sr = new System.IO.StringReader(txtInput.Text))
                {
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        var separator = Parsing.GetHeaderSeparator(line);
                        var items = Parsing.SmartSplit(line, separator);
                        if (iNom < items.Count && iPrenom < items.Count)
                            dgvCheck.Rows.Add(new object[] { items[iNom], items[iPrenom] });
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner nom et prénom pour pouvoir continuer.");
                tabControl1.SelectedTab = tabPage2;
            }
        }

        void FillResult(List<Tuple<string, string>> list)
        {
            foreach (DataGridViewRow row in dgvCheck.Rows)
                list.Add(new Tuple<string, string>(row.Cells[0].Value?.ToString(), row.Cells[1].Value?.ToString()));
        }

        public List<Tuple<string, string>> m_append;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            m_append = new List<Tuple<string, string>>();
            FillResult(m_append);
            DialogResult = DialogResult.OK;
        }

        public List<Tuple<string, string>> m_replace;
        private void btnReplace_Click(object sender, EventArgs e)
        {
            m_replace = new List<Tuple<string, string>>();
            FillResult(m_replace);
            DialogResult = DialogResult.Yes;
        }
    }
}
