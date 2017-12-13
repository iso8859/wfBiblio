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
            var lines = Csv.CsvReader.ReadFromStream(new System.IO.StreamReader(@"C:\Users\remi\Dropbox\Public\Mediathèque2000\Cocteau\biblio.csv", Encoding.UTF8).BaseStream);
            var collNotice = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Notice>("Notice");
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
                            localisation = Properties.Settings.Default.Localisation,
                            codeBarre = isbn
                        }
                    }
                };
                collNotice.InsertOne(notice);
            }

            lines = Csv.CsvReader.ReadFromStream(new System.IO.StreamReader(@"C:\Users\remi\Dropbox\Public\Mediathèque2000\Cocteau\adhérents.csv", Encoding.UTF8).BaseStream);
            var db = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            Dictionary<string, List<InfoLecteur>> tmp = new Dictionary<string, List<InfoLecteur>>();
            Dictionary<string, Lecteur> lecteurs = new Dictionary<string, Lecteur>();
            foreach (var line in lines)
            {
                string Codefamille = line["Codefamille"];
                if (Codefamille.StartsWith("Calmette"))
                {
                    if (!lecteurs.ContainsKey(Codefamille))
                        lecteurs[Codefamille] = new Lecteur()
                        {
                            titre = line["Codefamille"],
                            adresse = line["No"] + " " + line["Rue"],
                            codePostal = line["Code"],
                            ville = line["Ville"],
                            téléphone = line["Tel Pers"],
                            mail = line["Email"],
                            débutAdhésion = DateTime.Now,
                            finAdhésion = DateTime.Now.AddYears(1),
                            localisation = Properties.Settings.Default.Localisation
                        };
                    if (!tmp.ContainsKey(Codefamille))
                        tmp[Codefamille] = new List<InfoLecteur>();
                    tmp[Codefamille].Add(
                            new InfoLecteur()
                            {
                                nom = line["Nom"],
                                prénom = line["Prenom"],
                                localisation = Properties.Settings.Default.Localisation
                            }
                        );
                }
                else
                {
                    Lecteur lecteur = new Lecteur()
                    {
                        titre = line["Codefamille"],
                        adresse = line["No"] + " " + line["Rue"],
                        codePostal = line["Code"],
                        ville = line["Ville"],
                        téléphone = line["Tel Pers"],
                        mail = line["Email"],
                        débutAdhésion = DateTime.Now,
                        finAdhésion = DateTime.Now.AddYears(1),
                        localisation = Properties.Settings.Default.Localisation
                    };
                    db.GetCollection<Lecteur>("Lecteur").InsertOne(lecteur);
                    InfoLecteur infoLecteur = new InfoLecteur()
                    {
                        lecteurId = lecteur._id,
                        nom = line["Nom"],
                        prénom = line["Prenom"],
                        localisation = Properties.Settings.Default.Localisation
                    };
                    db.GetCollection<InfoLecteur>("InfoLecteur").InsertOne(infoLecteur);
                }
            }

            foreach (var key in lecteurs)
            {
                db.GetCollection<Lecteur>("Lecteur").InsertOne(key.Value);
                foreach (InfoLecteur il in tmp[key.Key])
                {
                    il.lecteurId = key.Value._id;
                    db.GetCollection<InfoLecteur>("InfoLecteur").InsertOne(il);
                }
            }

        }
    }
}
