using A=API.Modeles;
using D=DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace API.Mappers
{
    public static class Mappers
    {

        public static A.UserWithAdress DalToApiUserWithAdress(this D.Utilisateur u)
        {
            return new A.UserWithAdress()
            {
                UtilisateurID = u.UtilisateurID,
                Civilite = u.Civilite,
                Nom = u.Nom,
                Prenom = u.Prenom,
                AdresseID = u.AdresseID,
                //Adresse -> rue, cp, ville, numero
                DateNaiss = u.DateNaiss,
                NumTelDomicile = u.NumTelDomicile,
                NumTelPortable = u.NumTelPortable,
                NumFax = u.NumFax,
                EMail = u.EMail,


            };
        }

        public static D.Utilisateur ApiToDalUserWithAdress(this A.UserWithAdress u)
        {
            return new D.Utilisateur()
            {
                UtilisateurID = u.UtilisateurID,
                Civilite = u.Civilite,
                Nom = u.Nom,
                Prenom = u.Prenom,
                AdresseID = u.AdresseID,
                DateNaiss = u.DateNaiss,
                NumTelDomicile = u.NumTelDomicile,
                NumTelPortable = u.NumTelPortable,
                NumFax = u.NumFax,
                EMail = u.EMail,
            };
        }

    /***********************************/

        public static A.ThemeWithAdress DalToApiThemeWithAdress(this D.Theme t)
        {
            return new A.ThemeWithAdress()
            {
                ThemeID = t.ThemeID,
                Nom = t.Nom,
                Description = t.Description,
                HeureOuverture = t.HeureOuverture,
                HeureFermeture = t.HeureFermeture,
                LienSiteWeb = t.LienSiteWeb,
                AdresseID = t.AdresseID,
                PrixMin = t.PrixMin,
                PrixMax = t.PrixMax

            };
        }

        public static D.Theme ApiToDalThemeWithAdresse(this A.ThemeWithAdress t)
        {
            return new D.Theme()
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


    /*********************************************/

        public static A.PlanningWithUser DalToApiPlanningWithUser(this D.Planning p)
        {
            return new A.PlanningWithUser()
            {
                PlanningID = p.PlanningID,
                Date = p.Date,
                HeureDebut = p.HeureDebut,
                HeureFin = p.HeureFin,
                UtilisateurID = p.UtilisateurID,

            };
        }

        public static D.Planning ApiToDalPlanningWithUser(this A.PlanningWithUser p)
        {
            return new D.Planning()
            {
                PlanningID = p.PlanningID,
                Date = p.Date,
                HeureDebut = p.HeureDebut,
                HeureFin = p.HeureFin,
                UtilisateurID = p.UtilisateurID,
            };
        }

        /**************************************************/


        public static A.PlanningWithTheme DalToApiPlanningWithTheme(this D.Planning p)
        {
            return new A.PlanningWithTheme()
            {
                PlanningID = p.PlanningID,
                Date = p.Date,
                HeureDebut = p.HeureDebut,
                HeureFin = p.HeureFin,
                ThemeID = p.ThemeID,

            };
        }

        public static D.Planning ApiToDalPlanningWithTheme(this A.PlanningWithTheme p)
        {
            return new D.Planning()
            {
                PlanningID = p.PlanningID,
                Date = p.Date,
                HeureDebut = p.HeureDebut,
                HeureFin = p.HeureFin,
                ThemeID = p.ThemeID,
            };
        }


        /*****************************************************/

        public static A.AvisWithTheme DalToApiWithTheme(this D.Avis a)
        {
            return new A.AvisWithTheme()
            {
                DateCommentaire = a.DateCommentaire,
                Note = a.Note,
                Commentaire = a.Commentaire,
                ThemeID = a.ThemeID

            };
        }

        public static D.Avis ApitoDalAvis(this A.AvisWithTheme a)
        {
            return new D.Avis()
            {
                DateCommentaire = a.DateCommentaire,
                Note = a.Note,
                Commentaire = a.Commentaire,
                ThemeID = a.ThemeID

            };
        }

        /****************************************************/

        public static A.AvisWithUser DalToApiAvisWithUser(this D.Avis a)
        {
            return new A.AvisWithUser()
            {
                DateCommentaire = a.DateCommentaire,
                Note = a.Note,
                Commentaire = a.Commentaire,
                UtilisateurID = a.UtilisateurID

            };
        }

        public static D.Avis ApiToDAlAvisWithUser(this A.AvisWithUser a)
        {
            return new D.Avis()
            {
                DateCommentaire = a.DateCommentaire,
                Note = a.Note,
                Commentaire = a.Commentaire,
                UtilisateurID = a.UtilisateurID

            };
        }


    }

}
