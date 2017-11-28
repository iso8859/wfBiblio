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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void txtNotice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnSearchNotices_Click(sender, null);
        }

        private void btnSearchNotices_Click(object sender, EventArgs e)
        {
            var coll = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            dgvResultNotice.DataSource = null;
            var cursor = coll.Find(
                Builders<Notice>.Filter.Or(
                    Builders<Notice>.Filter.Regex(a => a.auteur, new MongoDB.Bson.BsonRegularExpression(txtNotice.Text, "/i")),
                    Builders<Notice>.Filter.Regex(a => a.titre, new MongoDB.Bson.BsonRegularExpression(txtNotice.Text, "/i")),
                    new BsonDocument("exemplaires.codeBarre", txtNotice.Text)
                    )
                );
            if (cursor != null)
                dgvResultNotice.DataSource = cursor.ToList();

            dgvResultNotice.AutoResizeColumns();
            txtNotice.SelectAll();
        }

        private void dgvResultNotice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResultNotice.SelectedRows.Count > 0)
                ctrlNotices1.SetNotice(((List<Notice>)dgvResultNotice.DataSource)[dgvResultNotice.SelectedRows[0].Index]);
            else
                ctrlNotices1.SetNotice(null);
        }

        private void btnAddNotice_Click(object sender, EventArgs e)
        {
            using (var frm = new frmAjouterNotice())
                frm.ShowDialog();
        }

        private void btnEnregistrerNotice_Click(object sender, EventArgs e)
        {
            Notice notice = ctrlNotices1.GetNotice();
            if (notice != null)
            {
                var coll = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
                coll.ReplaceOne(Builders<Notice>.Filter.Eq(a => a._id, notice._id), notice);
            }
        }

        private void btnCirculation_Click(object sender, EventArgs e)
        {
            var collNotice = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            var collEmprunt = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Emprunt>("Emprunt");
            var collLecteur = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Lecteur>("Lecteur");
            // Chercher lecteur ou exemplaire emprunté
            if (txtSearchCirculation.Text.All(char.IsDigit))
            {
                List<Notice> tmp = collNotice.Find(new BsonDocument("exemplaires.codeBarre", txtSearchCirculation.Text)).ToList();
                if (tmp != null)
                {
                    if (tmp.Count == 1)
                    {
                        Exemplaire exemplaire = tmp[0].exemplaires.Find(a => a.codeBarre == txtSearchCirculation.Text);
                        if (exemplaire != null)
                        {
                            // Retrouver le lecteur concerné
                            List<Emprunt> tmp2 = collEmprunt.Find(
                                Builders<Emprunt>.Filter.And(
                                    Builders<Emprunt>.Filter.Eq(a => a.IdExemplaire, exemplaire._id),
                                    Builders<Emprunt>.Filter.Eq(a => a.etat, 1))
                                ).ToList();
                            if (tmp2 != null && tmp2.Count > 0)
                                AffichageLecteur(tmp2[0].idLecteur);
                        }
                        else
                            MessageBox.Show("Erreur interne 1");
                    }
                    else
                        MessageBox.Show("Il existe plusieurs exemplaires ce qui est anormal");
                }
                else
                    MessageBox.Show("Cet exemplaire n'existe pas");
            }
            else
            {
                // Cherche le lecteur
                List<Lecteur> lecteurs = collLecteur.Find(
                    Builders<Lecteur>.Filter.Or(
                        Builders<Lecteur>.Filter.Regex(a => a.nom, new MongoDB.Bson.BsonRegularExpression(txtSearchCirculation.Text, "/i")),
                        Builders<Lecteur>.Filter.Regex(a => a.prénom, new MongoDB.Bson.BsonRegularExpression(txtSearchCirculation.Text, "/i"))
                        )
                    ).ToList();
                if (lecteurs != null)
                {
                    if (lecteurs.Count == 1)
                        AffichageLecteur(lecteurs[0]._id);
                    else
                    {
                        ctrlChoixLecteur choix = new ctrlChoixLecteur() { Dock = DockStyle.Fill };
                        choix.Init(lecteurs);
                        choix.ChoixLecteurEvent += Choix_ChoixLecteurEvent;
                        pnlCirculation.Controls.Clear();
                        pnlCirculation.Controls.Add(choix);
                    }
                }
                else
                    MessageBox.Show("Pas de lecteur à ce nom");
            }
        }

        private void Choix_ChoixLecteurEvent(Lecteur lecteur)
        {
            AffichageLecteur(lecteur._id);
        }

        private void AffichageLecteur(ObjectId lecteurId)
        {
            ctrlCirculation circ = new ctrlCirculation() { Dock = DockStyle.Fill };
            circ.Init(lecteurId);
            pnlCirculation.Controls.Clear();
            pnlCirculation.Controls.Add(circ);
        }

        private void txtSearchCirculation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnCirculation_Click(null, null);
        }
    }
}
