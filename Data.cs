using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBiblio
{
    public class Exemplaire
    {
        public ObjectId _id { get; set; }
        public string cote { get; set; }
        public string codeBarre { get; set; }
        public string localisation { get; set; }
        public string commentaires { get; set; }
        public string info { get; set; }
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }
    }

    public class Notice
    {
        public ObjectId _id { get; set; }
        public string titre { get; set; }
        public string complémentTitre { get; set; }
        public string auteur { get; set; }
        public string autresAuteurs { get; set; }
        public string éditeur { get; set; }
        public string année { get; set; }
        public string dateAchat { get; set; }
        public string collection { get; set; }
        public string isbn { get; set; }
        public string @public { get; set; }
        public string commentaires { get; set; }
        public List<Exemplaire> exemplaires { get; set; }
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }
    }

    public class Emprunt
    {
        public ObjectId _id { get; set; }
        public ObjectId IdExemplaire { get; set; }
        public ObjectId idLecteur { get; set; }
        public DateTime dateEmprunt { get; set; }
        public DateTime dateRetourPrévue { get; set; }
        public DateTime dateRetourEffective { get; set; }
        public string commentaires { get; set; }
        public int etat { get; set; } // 1 = emprunté, 2 = rendu
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }
    }

    public class LecteurResult
    {
        public Lecteur lecteur;
        public InfoLecteur infoLecteur;
    }

    public class InfoLecteur
    {
        public ObjectId _id { get; set; }
        public ObjectId lecteurId { get; set; }
        public string nom { get; set; }
        public string prénom { get; set; }
        public string commentaires { get; set; }
        public string localisation { get; set; }
        public DateTime dateSuppression { get; set; }
        [BsonIgnore]
        public int nombreDemprunts { get; set; }
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }

        public List<Emprunt> TrouverEmprunt()
        {
            var collEmprunt = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio").GetCollection<Emprunt>("Emprunt");
            return collEmprunt.Find(
                Builders<Emprunt>.Filter.And(
                    Builders<Emprunt>.Filter.Eq(a => a.idLecteur, _id),
                    Builders<Emprunt>.Filter.Eq(a => a.etat, 1)
                    )
                ).ToList();
        }
    }

    public class Lecteur
    {
        public ObjectId _id { get; set; }
        public string titre { get; set; }
        public string adresse { get; set; }
        public string codePostal { get; set; }
        public string ville { get; set; }
        public string mail { get; set; }
        public string téléphone { get; set; }
        public DateTime débutAdhésion { get; set; }
        public DateTime finAdhésion { get; set; }
        public DateTime dernierEmprunt { get; set; }
        public string localisation { get; set; }
        public string commentaires { get; set; }
        public int duréeEmprunts { get; set; }
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }

        public Lecteur()
        {
            duréeEmprunts = 21;
        }

        public static LecteurResult TrouverLecteurParId(ObjectId id)
        {
            var db = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            LecteurResult result = new LecteurResult()
            {
                infoLecteur = db.GetCollection<InfoLecteur>("InfoLecteur").Find(Builders<InfoLecteur>.Filter.Eq(a => a._id, id)).FirstOrDefault()
            };
            if (result.infoLecteur != null)
                result.lecteur = db.GetCollection<Lecteur>("Lecteur").Find(Builders<Lecteur>.Filter.Eq(a => a._id, result.infoLecteur.lecteurId)).FirstOrDefault();
            return result;
        }

        public static List<LecteurResult> TrouverLecteursParSearch(string search)
        {
            List<LecteurResult> result = new List<LecteurResult>();
            var db = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            var s = new MongoDB.Bson.BsonRegularExpression(search, "/i");
            foreach (InfoLecteur il in db.GetCollection<InfoLecteur>("InfoLecteur").Find(
                Builders<InfoLecteur>.Filter.And(
                    Builders<InfoLecteur>.Filter.Eq(a => a.localisation, Properties.Settings.Default.Localisation),
                    Builders<InfoLecteur>.Filter.Or(
                        Builders<InfoLecteur>.Filter.Regex(a => a.nom, s),
                        Builders<InfoLecteur>.Filter.Regex(a => a.prénom, s),
                        Builders<InfoLecteur>.Filter.Regex(a => a.commentaires, s)
                        )
                    )
                ).ToList())
            {
                LecteurResult lr = new LecteurResult()
                {
                    infoLecteur = il,
                    lecteur = db.GetCollection<Lecteur>("Lecteur").Find(Builders<Lecteur>.Filter.Eq(a => a._id, il.lecteurId)).FirstOrDefault()
                };
                result.Add(lr);
            }

            // Rechercher par titre
            foreach (Lecteur lecteur in db.GetCollection<Lecteur>("Lecteur").Find(Builders<Lecteur>.Filter.Regex(a => a.titre, s)).ToList())
            {
                foreach (InfoLecteur il in db.GetCollection<InfoLecteur>("InfoLecteur").Find(Builders<InfoLecteur>.Filter.Eq(a => a.lecteurId, lecteur._id)).ToList())
                {
                    if (result.Find(a => a.infoLecteur._id == il._id) == null)
                        result.Add(new LecteurResult() { infoLecteur = il, lecteur = lecteur });
                }
            }

            result.Sort((a, b) => {
                if (a.infoLecteur.nom.ToLower() != b.infoLecteur.nom.ToLower())
                    return a.infoLecteur.nom.ToLower().CompareTo(b.infoLecteur.nom.ToLower());
                else
                    return a.infoLecteur.prénom.ToLower().CompareTo(b.infoLecteur.prénom.ToLower());
            });

            return result;
        }

        public static List<LecteurResult> TrouverLecteursParGroupe(InfoLecteur ilParent)
        {
            List<LecteurResult> result = new List<LecteurResult>();
            var db = new MongoDB.Driver.MongoClient(Properties.Settings.Default.MongoDB).GetDatabase("wfBiblio");
            foreach (InfoLecteur il in db.GetCollection<InfoLecteur>("InfoLecteur").Find(Builders<InfoLecteur>.Filter.Eq(a => a.lecteurId, ilParent.lecteurId)).ToList())
            {
                LecteurResult lr = new LecteurResult()
                {
                    infoLecteur = il,
                    lecteur = db.GetCollection<Lecteur>("Lecteur").Find(Builders<Lecteur>.Filter.Eq(a => a._id, il.lecteurId)).FirstOrDefault()
                };
                result.Add(lr);
            }

            result.Sort((a, b) => {
                if (a.infoLecteur.nom.ToLower() != b.infoLecteur.nom.ToLower())
                    return a.infoLecteur.nom.ToLower().CompareTo(b.infoLecteur.nom.ToLower());
                else
                    return a.infoLecteur.prénom.ToLower().CompareTo(b.infoLecteur.prénom.ToLower());
            });

            return result;
        }
    }
}
