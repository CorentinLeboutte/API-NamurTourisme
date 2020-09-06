using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.IRepository
{
    public interface IAdresseRepository
    {
        int Create(Adresse Adresse);
        void Delete(int Id);
        IEnumerable<Adresse> Get();
        Adresse GetById(int Id);
        int Update(Adresse Adresse);
    }
}