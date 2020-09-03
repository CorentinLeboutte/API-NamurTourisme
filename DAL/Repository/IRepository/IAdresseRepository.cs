using DAL.Models;
using System.Collections.Generic;

namespace DAL.Repository.IRepository
{
    public interface IAdresseRepository
    {
        void Create(Adresse newAdresseToInsert);
        void Delete(int idToDelete);
        List<Adresse> Get();
        Adresse Get(int idToGet);
        void Update(Adresse AdressetoUpdate);
    }
}