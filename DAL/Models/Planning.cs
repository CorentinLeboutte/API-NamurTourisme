using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    class Planning
    {

        public int PlanningID { get; set; }

        public DateTime Date { get; set; }

        public DateTime HeureDebut { get; set; }

        public DateTime HeureFin { get; set; }

        public int UtilisateurID { get; set; }


    }
}
