using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Modeles
{
    public class PlanningWithUtilisateur
    {
        public int PlanningID { get; set; }

        public DateTime Date { get; set; }

        public DateTime HeureDebut { get; set; }

        public DateTime HeureFin { get; set; }

        public int UtilisateurID { get; set; }

        public Utilisateur Utilisateur { get; set; }


    }
}
