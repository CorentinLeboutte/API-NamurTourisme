﻿using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.Repositories
{
    public interface IPlanningRepository
    {
        int Create(Planning plan);
        IEnumerable<Planning> Get();
        Planning GetById(int Id);
        int Update(Planning plan);
    }
}