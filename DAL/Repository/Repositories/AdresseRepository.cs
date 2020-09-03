using DAL.Models;
using DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories
{
    public class AdresseRepository : IAdresseRepository
    {
        private Connection _connection;
        public AdresseRepository(Connection connection)
        {
            _connection = connection;
        }

        // CRUD 

        public List<Adresse> Get()
        {
            List<Adresse> GetAllAdresse = new List<Adresse>();

            using(Connection _connection)
            {
                _connection.Open();
            }

        }

        public Adresse Get(int idToGet)
        {
            return new Adresse();
        }

        public void Create(Adresse newAdresseToInsert)
        {

        }

        public void Update(Adresse AdressetoUpdate)
        {

        }

        public void Delete(int idToDelete)
        {

        }
    }
}
