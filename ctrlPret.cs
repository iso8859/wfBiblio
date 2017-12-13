using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfBiblio
{
    public partial class ctrlPret : UserControl
    {
        public ctrlPret()
        {
            InitializeComponent();
        }

        public delegate void RetourHandler(ctrlPret ctrl);
        public event RetourHandler RetourEvent;
        private void btnRetour_Click(object sender, EventArgs e)
        {
            if (RetourEvent != null)
                RetourEvent(this);
        }
    }
}
