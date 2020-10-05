﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
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
