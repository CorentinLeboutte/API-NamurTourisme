using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class Theme
    {
        public int ThemeID { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public DateTime HeureOuverture { get; set; }

        public DateTime HeureFermeture { get; set; }

        public string LienSiteWeb { get; set; }

        public int AdresseID { get; set; }


    }
}
