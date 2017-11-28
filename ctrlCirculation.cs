using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace wfBiblio
{
    public partial class ctrlCirculation : UserControl
    {
        public ctrlCirculation()
        {
            InitializeComponent();
        }

        ObjectId m_lecteurId;
        public void Init(ObjectId lecteurId)
        {
            m_lecteurId = lecteurId;
            var collLecteur = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Lecteur>("Lecteur");
            List<Lecteur> lecteurs = collLecteur.Find(new BsonDocument("_id", lecteurId)).ToList();
            if( lecteurs!=null && lecteurs.Count>0)
            {
                lblNom.Text = lecteurs[0].nom;
                lblPrenom.Text = lecteurs[0].prénom;
            }
            FillPrêts();
        }

        void FillPrêts()
        {
            flowLayoutPanel1.Controls.Clear();
            // Retrouver les prêts en cours du lecteur
            var collNotice = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            var collEmprunt = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Emprunt>("Emprunt");
            List<Emprunt> emprunts = collEmprunt.Find(
                    Builders<Emprunt>.Filter.And(
                        Builders<Emprunt>.Filter.Eq(a => a.idLecteur, m_lecteurId),
                        Builders<Emprunt>.Filter.Eq(a => a.etat, 1)
                        )
                ).ToList();
            foreach (Emprunt e in emprunts)
            {
                List<Notice> tmp = collNotice.Find(new BsonDocument("exemplaires._id", e.IdExemplaire)).ToList();
                if (tmp != null && tmp.Count > 0)
                {
                    ctrlPret p = new ctrlPret();
                    p.txtTitre.Text = tmp[0].titre;
                    p.txtAuteur.Text = tmp[0].auteur;
                    p.txtExemplaire.Text = tmp[0].exemplaires.Find(a => a._id == e.IdExemplaire).codeBarre;
                    p.txtDatepret.Text = e.dateEmprunt.ToString("dd/MM/yyyy");
                    p.txtDateRetour.Text = e.dateRetourPrévue.ToString("dd/MM/yyyy");
                    p.Tag = tmp[0];
                    flowLayoutPanel1.Controls.Add(p);
                }
            }
        }

        private void txtNewExplaire_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnOK_Click(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Ajouter ou supprimer un exemplaire
            var collNotice = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            var collEmprunt = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Emprunt>("Emprunt");
            List<Notice> tmp = collNotice.Find(new BsonDocument("exemplaires.codeBarre", txtNewExplaire.Text)).ToList();
            if (tmp!=null && tmp.Count==1)
            {
                // Cet exemplaire est-il disponible?
                List<Emprunt> emprunts = collEmprunt.Find(
                        Builders<Emprunt>.Filter.And(
                            Builders<Emprunt>.Filter.Eq(a => a.IdExemplaire, tmp[0].exemplaires.Find(a => a.codeBarre == txtNewExplaire.Text)._id),
                            Builders<Emprunt>.Filter.Eq(a => a.etat, 1)
                            )
                    ).ToList();
                if (emprunts == null || emprunts.Count==0)
                {
                    // L'ajouter pour ce lecteur
                    Emprunt emprunt = new Emprunt()
                    {
                        idLecteur = m_lecteurId,
                        IdExemplaire = tmp[0].exemplaires.Find(a => a.codeBarre == txtNewExplaire.Text)._id,
                        etat = 1,
                        dateEmprunt = DateTime.Now,
                        dateRetourPrévue = DateTime.Now.AddDays(21)
                    };
                    collEmprunt.InsertOne(emprunt);
                    FillPrêts();
                }
                else if (emprunts.Count > 0)
                {
                    // Est-ce le lecteur en cours
                    if (emprunts[0].idLecteur == m_lecteurId)
                    {
                        // Le supprimer de la liste des emprunts de ce lecteur
                        collEmprunt.UpdateOne(Builders<Emprunt>.Filter.Eq(a => a._id, emprunts[0]._id),
                            Builders<Emprunt>.Update.Set(a => a.etat, 2).CurrentDate(a => a.dateRetourEffective));
                        FillPrêts();
                    }
                    else
                    {
                        // Retrouver le lecteur
                        var collLecteur = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Lecteur>("Lecteur");
                        var lecteurs = collLecteur.Find(new BsonDocument("_id", emprunts[0].idLecteur)).ToList();
                        if (lecteurs != null && lecteurs.Count > 0)
                            MessageBox.Show($"Ce document est déjà emprunté par {lecteurs[0].nom} {lecteurs[0].prénom}");
                    }
                }
            }
        }
    }
}
