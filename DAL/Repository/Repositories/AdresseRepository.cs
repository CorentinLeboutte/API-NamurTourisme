using DAL.Models;
using DAL.Repository.IRepository;
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

        //CREATE

        public int Create(Adresse adress)
        {
            Command cmd = new Command("Create_Adresse", true);
            cmd.AddParameter("longitude", adress.Longitude);
            cmd.AddParameter("latitude", adress.Latitude);
            cmd.AddParameter("rue", adress.Rue);
            cmd.AddParameter("numero", adress.Numero);
            cmd.AddParameter("boite", adress.Boite);
            cmd.AddParameter("ville", adress.Ville);
            cmd.AddParameter("codePostal", adress.CodePostal);
            cmd.AddParameter("region", adress.Region);
            cmd.AddParameter("pays", adress.Pays);


            return _connection.ExecuteNonQuery(cmd);
        }

        //READ

        public IEnumerable<Adresse> GetAll()
        {
            Command cmd = new Command("Select * from Adresse");
            return _connection.ExecuteReader(cmd, reader => new Adresse()
            {
                AdresseID = (int)reader["AdresseId"],
                Longitude = reader["Longitude"].ToString(),
                Latitude = reader["Latitude"].ToString(),
                Rue = reader["Rue"] is DBNull ? null : reader["Rue"].ToString(),
                Numero = reader["Numero"] is DBNull ? null : reader["Numero"].ToString(),
                Boite = reader["Boite"] is DBNull ? null : reader["Boite"].ToString(),
                Ville = reader["Ville"] is DBNull ? null : reader["Ville"].ToString(),

                //CodePostal = reader["CodePostal"],is DBNull ? null : reader["CodePostal"],

                Region = reader["Region"] is DBNull ? null : reader["Region"].ToString(),
                Pays = reader["Pays"] is DBNull ? null : reader["Pays"].ToString(),
            });

        }

        //UPDATE

        public void Update(Adresse adress)
        {
            Command cmd = new Command("Update_Adresse", true);
            cmd.AddParameter("longitude", adress.Longitude);
            cmd.AddParameter("latitude", adress.Latitude);
            cmd.AddParameter("rue", adress.Rue);
            cmd.AddParameter("numero", adress.Numero);
            cmd.AddParameter("boite", adress.Boite);
            cmd.AddParameter("ville", adress.Ville);
            cmd.AddParameter("codePostal", adress.CodePostal);
            cmd.AddParameter("region", adress.Region);
            cmd.AddParameter("pays", adress.Pays);

        }

        //DELETE


    }
}
