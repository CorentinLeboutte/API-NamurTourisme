﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class AvisWithTheme
    {
        public int AvisID { get; set; }

        public int UtilisateurID { get; set; }

        public int ThemeID { get; set; }

        public int? Note { get; set; }

        public string Commentaire { get; set; }

        public DateTime? DateCommentaire { get; set; }

        public Theme Theme { get; set; }
    }
}
