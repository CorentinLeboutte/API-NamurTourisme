using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Modeles
{
    public class UserWithAdress
    {
        public int UtilisateurID { get; set; }

        public string Civilite { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int AdresseID { get; set; }

        public DateTime DateNaiss { get; set; }

        public string NumTelDomicile { get; set; }

        public string NumTelPortable { get; set; }

        public string NumFax { get; set; }

        public string EMail { get; set; }

        public string Mdp { get; set; }
        public Adresse Adresse { get; internal set; }
    }
}
