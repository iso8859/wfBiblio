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
    public partial class frmrExemplaire : Form
    {
        public frmrExemplaire()
        {
            InitializeComponent();
        }

        public void SetExemplaire(Exemplaire exemplaire)
        {
            exemplaireBindingSource.DataSource = new List<Exemplaire> { exemplaire };
            exemplaireBindingSource.Position = 0;
        }

        public Exemplaire GetExemplaire()
        {
            exemplaireBindingSource.EndEdit();
            return ((List<Exemplaire>)exemplaireBindingSource.DataSource)[0];
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
