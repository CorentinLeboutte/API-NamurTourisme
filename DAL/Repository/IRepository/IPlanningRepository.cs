using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.Repositories
{
    public interface IPlanningRepository
    {
        int Create(Planning plan);
        IEnumerable<Planning> GetAll();
        void Update(Planning plan);
    }
}