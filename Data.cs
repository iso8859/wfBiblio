using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfBiblio
{
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
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }
    }

    public class Exemplaire
    {
        public ObjectId _id { get; set; }
        public ObjectId noticeId { get; set; }
        public string localisation { get; set; }
        public string cote { get; set; }
        public string codeBarre { get; set; }
        public string commentaires { get; set; }
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }
    }

    public class Emprunt
    {
        public ObjectId _id { get; set; }
        public ObjectId idExemplaire { get; set; }
        public ObjectId idEmprunteur { get; set; }
        public DateTime dateEmprunt { get; set; }
        public DateTime dateRetour { get; set; }
        public string commentaires { get; set; }
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }
    }

    public class Emprunteur
    {
        public ObjectId _id { get; set; }
        public int type { get; set; }
        public List<ObjectId> rattachements { get; set; }
        public string nom { get; set; }
        public string prénom { get; set; }
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
        [BsonExtraElements]
        public BsonDocument indexes { get; set; }
    }
}
