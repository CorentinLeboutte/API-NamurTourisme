using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories
{
    public class AdresseRepository
    {
        private Connection _connection;
        public AdresseRepository(Connection connection)
        {
            _connection = connection;
        }


        // CRUD 

        public List<Adresse> Get()
        {
            return new List<Adresse>();

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
