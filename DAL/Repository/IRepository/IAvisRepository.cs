using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.Repositories
{
    public interface IAvisRepository
    {
        int Create(Avis avis);
        void Delete(int Id);
        IEnumerable<Avis> Get();
        Avis GetById(int Id);
        int Update(Avis avis);
    }
}