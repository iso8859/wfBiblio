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

        public void Init(List<LecteurResult> lecteurs)
        {
            foreach (var lecteur in lecteurs)
            {
                if (lecteur.infoLecteur == null)
                    lecteur.infoLecteur = new InfoLecteur();
                if (lecteur.lecteur == null)
                    lecteur.lecteur = new Lecteur();
                LinkLabel ll = new LinkLabel() { Text = $"{lecteur.infoLecteur.nom??""} {lecteur.infoLecteur.prénom??""} ({lecteur.lecteur.titre??""})", Tag = lecteur, AutoSize = true, BackColor = System.Drawing.Color.AliceBlue, BorderStyle = BorderStyle.FixedSingle, Padding = new Padding(5) };
                ll.Click += Ll_Click;
                flowLayoutPanel1.Controls.Add(ll);
            }
        }

        public delegate void ChoixLecteurDelegate(LecteurResult lecteur);
        public event ChoixLecteurDelegate ChoixLecteurEvent;

        private void Ll_Click(object sender, EventArgs e)
        {
            if (ChoixLecteurEvent != null)
                ChoixLecteurEvent((LecteurResult)((LinkLabel)sender).Tag);
        }
    }
}