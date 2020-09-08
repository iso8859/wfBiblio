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
            lblResult.Text = "";
            var coll = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            dgvResultNotice.DataSource = null;
            var cursor = coll.Find(
                Builders<Notice>.Filter.Or(
                    Builders<Notice>.Filter.Regex(a => a.auteur, new MongoDB.Bson.BsonRegularExpression(txtNotice.Text, "/i")),
                    Builders<Notice>.Filter.Regex(a => a.titre, new MongoDB.Bson.BsonRegularExpression(txtNotice.Text, "/i")),
                    Builders<Notice>.Filter.Regex(a => a.éditeur, new MongoDB.Bson.BsonRegularExpression(txtNotice.Text, "/i")),
                    new BsonDocument("exemplaires.codeBarre", txtNotice.Text)
                    )
                ).Limit(100);
            if (cursor != null)
            {
                var tmp = cursor.ToList();
                dgvResultNotice.DataSource = tmp;
                lblResult.Text = $"{tmp.Count} réponse(s)";
            }
            else
                lblResult.Text = "Aucune réponse";

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
            ctrlNotices1.Enregistrer();
            //Notice notice = ctrlNotices1.GetNotice();
            //if (notice != null)
            //{
            //    var coll = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            //    coll.ReplaceOne(Builders<Notice>.Filter.Eq(a => a._id, notice._id), notice);
            //}
        }

        private void btnCirculation_Click(object sender, EventArgs e)
        {
            var collNotice = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            var collEmprunt = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Emprunt>("Emprunt");
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
                                AffichageLecteur(Lecteur.TrouverLecteurParId(tmp2[0].idLecteur));
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
                List<LecteurResult> lr = Lecteur.TrouverLecteursParSearch(txtSearchCirculation.Text);
                if (lr.Count>0)
                {
                    if (lr.Count == 1)
                        AffichageLecteur(lr[0]);
                    else
                    {
                        ctrlChoixLecteur choix = new ctrlChoixLecteur() { Dock = DockStyle.Fill };
                        choix.Init(lr);
                        choix.ChoixLecteurEvent += Choix_ChoixLecteurEvent;
                        pnlCirculation.Controls.Clear();
                        pnlCirculation.Controls.Add(choix);
                    }
                }
                else
                    MessageBox.Show("Pas de lecteur à ce nom");
            }
            txtSearchCirculation.SelectAll();
        }

        private void Choix_ChoixLecteurEvent(LecteurResult lecteur)
        {
            AffichageLecteur(lecteur);
        }

        private void AffichageLecteur(LecteurResult lecteur)
        {
            ctrlCirculation circ = new ctrlCirculation() { Dock = DockStyle.Fill };
            circ.Init(lecteur);
            circ.AfficherGroupeEvent += Circ_AfficherGroupeEvent;
            pnlCirculation.Controls.Clear();
            pnlCirculation.Controls.Add(circ);
        }

        private void Circ_AfficherGroupeEvent(LecteurResult lr)
        {
            // Retrouver les membres du groupe
            ctrlChoixLecteur choix = new ctrlChoixLecteur() { Dock = DockStyle.Fill };
            choix.Init(Lecteur.TrouverLecteursParGroupe(lr.infoLecteur));
            choix.ChoixLecteurEvent += Choix_ChoixLecteurEvent;
            pnlCirculation.Controls.Clear();
            pnlCirculation.Controls.Add(choix);
        }

        private void txtSearchCirculation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnCirculation_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            txtSearchCirculation.Focus();
        }

        private void btnChercherNotice_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void btnAddLecteur_Click(object sender, EventArgs e)
        {
            using (frmLecteur lecteur = new frmLecteur())
            {
                lecteur.Init(new LecteurResult() { lecteur = new Lecteur() { _id = ObjectId.GenerateNewId(), débutAdhésion = DateTime.Now, finAdhésion = DateTime.Now.AddYears(1), dernierEmprunt = new DateTime(2000, 1, 1), duréeEmprunts = 21 } });
                lecteur.ShowDialog();
            }
        }

        private void txtSearchCirculation_Click(object sender, EventArgs e)
        {
            txtSearchCirculation.SelectAll();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var collDesherbage = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Desherbage>("Desherbage");
            var l = collDesherbage.Find(_ => true).SortByDescending(bson => bson.dt).ToList();
            dgvDesherbage.DataSource = l;
            dgvDesherbage.AutoResizeColumns();
            dgvDesherbage.Columns["_id"].Visible = false;
            dgvDesherbage.Columns["idNotice"].Visible = false;
        }
    }
}
