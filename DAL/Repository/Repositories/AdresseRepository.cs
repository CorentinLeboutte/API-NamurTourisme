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

        public int Create(Adresse user)
        {
            Command cmd = new Command("Create_Adresse", true);
            cmd.AddParameter("longitude", user.Longitude);
            cmd.AddParameter("latitude", user.Latitude);
            cmd.AddParameter("rue", user.Rue);
            cmd.AddParameter("numero", user.Numero);
            cmd.AddParameter("boite", user.Boite);
            cmd.AddParameter("ville", user.Ville);
            cmd.AddParameter("codePostal", user.CodePostal);
            cmd.AddParameter("region", user.Region);
            cmd.AddParameter("pays", user.Pays);


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

        public void Update(Adresse user)
        {
            Command cmd = new Command("Update_Adresse", true);
            cmd.AddParameter("longitude", user.Longitude);
            cmd.AddParameter("latitude", user.Latitude);
            cmd.AddParameter("rue", user.Rue);
            cmd.AddParameter("numero", user.Numero);
            cmd.AddParameter("boite", user.Boite);
            cmd.AddParameter("ville", user.Ville);
            cmd.AddParameter("codePostal", user.CodePostal);
            cmd.AddParameter("region", user.Region);
            cmd.AddParameter("pays", user.Pays);

        }

        //DELETE


    }
}
