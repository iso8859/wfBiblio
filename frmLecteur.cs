using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            titreComboBox.DataSource = db.GetCollection<Lecteur>("Lecteur").Distinct<string>("titre", "{}").ToList();
            villeComboBox.DataSource = db.GetCollection<Lecteur>("Lecteur").Distinct<string>("ville", "{}").ToList();
            codePostalComboBox.DataSource = db.GetCollection<Lecteur>("Lecteur").Distinct<string>("codePostal", "{}").ToList();
        }

        private void infoLecteurBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new InfoLecteur() { _id = ObjectId.GenerateNewId() };
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

        private void btnListeEmprunts_Click(object sender, EventArgs ea)
        {
            if (saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.Default))
                {
                    sw.WriteLine("Groupe;Nom;Prénom;Titre;Auteur;Date Emprunt;Date Retour;Exemplaire");
                    var db = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
                    var collNotice = db.GetCollection<Notice>("Notice");

                    lecteurBindingSource.EndEdit();
                    Lecteur lecteur = ((List<Lecteur>)lecteurBindingSource.DataSource)[0];
                    foreach (InfoLecteur il in db.GetCollection<InfoLecteur>("InfoLecteur").Find(a => a.lecteurId == lecteur._id).ToList())
                    {
                        foreach (Emprunt emprunt in il.TrouverEmprunt())
                        {
                            List<Notice> tmp = collNotice.Find(new BsonDocument("exemplaires._id", emprunt.IdExemplaire)).ToList();
                            if (tmp != null && tmp.Count > 0)
                            {
                                Exemplaire ex = tmp[0].exemplaires.Find(a => a._id == emprunt.IdExemplaire);
                                sw.WriteLine($"{lecteur.titre};{il.nom};{il.prénom};{tmp[0].titre};{tmp[0].auteur};{emprunt.dateEmprunt.ToString("dd/MM/yyyy")};{emprunt.dateRetourPrévue.ToString("dd/MM/yyyy")};'{ex.codeBarre}");
                            }
                        }
                    }
                }
                System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + saveFileDialog1.FileName + "\"");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cela ne fonctionne pas encore");
        }
    }
}
