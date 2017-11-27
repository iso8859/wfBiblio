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
    public partial class ImportNoticeExemplaires : Form
    {
        public ImportNoticeExemplaires()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lines = Csv.CsvReader.ReadFromStream(new System.IO.StreamReader(@"I:\Dropbox\Public\Mediathèque2000\Cocteau\biblio.csv", Encoding.UTF8).BaseStream);
            var collNotice = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
            var collExemplaire = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Exemplaire>("Exemplaire");
            foreach (var line in lines)
            {
                string isbn = "";
                try
                {
                    isbn = line["ISBN"];
                }
                catch
                {
                    try
                    {
                        isbn = line["ISSN"];
                    }
                    catch
                    {

                    }
                }

                Notice notice = new Notice()
                {
                    titre = line["Titre"],
                    auteur = line["Auteur"],
                    éditeur = line["Editeur"],
                    année = line["Annee d'edition"],
                    dateAchat = line["Date d'achat"],
                    collection = line["Collection"],
                    isbn = isbn,
                    @public = line["Public"],
                };
                collNotice.InsertOne(notice);

                Exemplaire ex = new Exemplaire()
                {
                    noticeId = notice._id,
                    codeBarre = notice.isbn
                };
                collExemplaire.InsertOne(ex);
            }
        }
    }
}
