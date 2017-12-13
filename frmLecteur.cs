using MongoDB.Bson;
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
    public partial class frmLecteur : Form
    {
        public frmLecteur()
        {
            InitializeComponent();
        }

        public void Init(LecteurResult lr)
        {
            var db = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            infoLecteurBindingSource.DataSource = db.GetCollection<InfoLecteur>("InfoLecteur").Find(a => a.lecteurId == lr.lecteur._id).ToList();
            lecteurBindingSource.DataSource = new List<Lecteur>() { lr.lecteur };
            lecteurBindingSource.Position = 0;
        }

        private void infoLecteurBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new InfoLecteur();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lecteurBindingSource.EndEdit();
            infoLecteurBindingSource.EndEdit();
            var db = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            Lecteur lecteur = ((List<Lecteur>)lecteurBindingSource.DataSource)[0];
            lecteur.localisation = Properties.Settings.Default.Localisation;
            var ops = new UpdateOptions { IsUpsert = true };
            db.GetCollection<Lecteur>("Lecteur").ReplaceOne(x => x._id == lecteur._id, lecteur, ops);
            foreach (InfoLecteur il in (List<InfoLecteur>)infoLecteurBindingSource.DataSource)
            {
                il.localisation = Properties.Settings.Default.Localisation;
                il.lecteurId = lecteur._id;
                db.GetCollection<InfoLecteur>("InfoLecteur").ReplaceOne(x => x._id == il._id, il, ops);
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // List<Emprunt> TrouverEmpruntLecteur

        private void btnListeEmprunts_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
