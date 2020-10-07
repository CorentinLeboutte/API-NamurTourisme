using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Modeles
{
    public class ThemeWithAdress
    {
        public int ThemeID { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public DateTime? HeureOuverture { get; set; }

        public DateTime? HeureFermeture { get; set; }

        public string LienSiteWeb { get; set; }

        public Adresse Adresse { get; set; }

        public int AdresseID { get; set; }

        public string TypeDePaiement { get; set; }

        public decimal? PrixMin { get; set; }

        public decimal? PrixMax { get; set; }

    }
}
