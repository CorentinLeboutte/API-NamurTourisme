using API.Modeles;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappers
{
    public static class Mappers
    {
        public static UserWithAdress DalToApi(this Utilisateur u)
        {
            return new UserWithAdress()
            {
                UtilisateurID = u.UtilisateurID,
                Civilite = u.Civilite,
                Nom = u.Nom,
                Prenom = u.Prenom,
                AdresseId = u.AdresseID,
                DateNaiss = u.DateNaiss,
                NumTelDomicile = u.NumTelDomicile,
                NumTelPortable = u.NumTelPortable,
                NumFax = u.NumFax,
                EMail = u.EMail,


            };
        }

        public static ThemeWithAdress DalToApi(this Theme t)
        {
            return new ThemeWithAdress()
            {
                ThemeID = t.ThemeID,
                Nom = t.Nom,
                Description = t.Description,
                HeureOuverture = t.HeureOuverture,
                HeureFermeture = t.HeureFermeture,
                LienSiteWeb = t.LienSiteWeb,
                AdresseID = t.AdresseID,

            };
        }
    }
}
