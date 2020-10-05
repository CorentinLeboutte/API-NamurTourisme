using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class UserWithAdress
    {
        public int UtilisateurID { get; set; }

        public string Civilite { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public Adresse Adresse { get; set; }

        public int AdresseId { get; set; }

        public DateTime DateNaiss { get; set; }

        public string NumTelDomicile { get; set; }

        public string NumTelPortable { get; set; }

        public string NumFax { get; set; }

        public string EMail { get; set; }

        public string Mdp { get; set; }
    }
}
