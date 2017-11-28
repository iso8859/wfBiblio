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
    public class Import
    {
        public static void Importer()
        {
            var lines = Csv.CsvReader.ReadFromStream(new System.IO.StreamReader(@"I:\Dropbox\Public\Mediathèque2000\Cocteau\biblio.csv", Encoding.UTF8).BaseStream);
            var collNotice = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
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
                    exemplaires = new List<Exemplaire>()
                    {
                        new Exemplaire()
                        {
                            _id = MongoDB.Bson.ObjectId.GenerateNewId(),
                            codeBarre = isbn
                        }
                    }
                };
                collNotice.InsertOne(notice);
            }

            lines = Csv.CsvReader.ReadFromStream(new System.IO.StreamReader(@"I:\Dropbox\Public\Mediathèque2000\Cocteau\adhérents.csv", Encoding.UTF8).BaseStream);
            var collLecteur = new MongoDB.Driver.MongoClient().GetDatabase("wfBiblio").GetCollection<Lecteur>("Lecteur");
            foreach (var line in lines)
            {
                Lecteur lecteur = new Lecteur()
                {
                    nom = line["Nom"],
                    prénom = line["Prenom"],
                    adresse = line["No"] + " " + line["Rue"],
                    codePostal = line["Code"],
                    ville = line["Ville"],
                    type = line["Codefamille"],
                    téléphone = line["Tel Pers"],
                    mail = line["Email"],
                    débutAdhésion = DateTime.Now,
                    finAdhésion = DateTime.Now.AddYears(1),
                    localisation = "Cocteau"
                };
                collLecteur.InsertOne(lecteur);
            }
        }
    }
}
