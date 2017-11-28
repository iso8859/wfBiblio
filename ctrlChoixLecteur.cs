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
    public partial class ctrlChoixLecteur : UserControl
    {
        public ctrlChoixLecteur()
        {
            InitializeComponent();
        }

        public void Init(List<Lecteur> lecteurs)
        {
            foreach (var lecteur in lecteurs)
            {
                LinkLabel ll = new LinkLabel() { Text = $"{lecteur.nom} {lecteur.prénom}", Tag = lecteur, AutoSize = true };
                ll.Click += Ll_Click;
                flowLayoutPanel1.Controls.Add(ll);
            }
        }

        public delegate void ChoixLecteurDelegate(Lecteur lecteur);
        public event ChoixLecteurDelegate ChoixLecteurEvent;

        private void Ll_Click(object sender, EventArgs e)
        {
            if (ChoixLecteurEvent != null)
                ChoixLecteurEvent((Lecteur)((LinkLabel)sender).Tag);
        }
    }
}