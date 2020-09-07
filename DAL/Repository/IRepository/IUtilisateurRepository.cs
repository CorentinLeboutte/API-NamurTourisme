﻿using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.Repositories
{
    public interface IUtilisateurRepository
    {
        int Create(Utilisateur user);
        IEnumerable<Utilisateur> GetAll();
        void Update(Utilisateur user);
    }
}