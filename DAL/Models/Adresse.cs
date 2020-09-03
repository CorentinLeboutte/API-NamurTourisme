using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Adresse
    {
        public int AdresseID { get; set; }

        public string Longitude { get; set; }

        public string  Latitude { get; set; }

        public string Rue { get; set; }

        public string Numero { get; set; }

        public string Boite { get; set; }

        public int CodePostal { get; set; }

        public string Ville { get; set; }

        public string Region { get; set; }

        public string Pays { get; set; }

    }
}
