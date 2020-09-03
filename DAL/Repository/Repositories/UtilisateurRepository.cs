using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories
{
    public class UtilisateurRepository
    {
        private Connection _connection;
        public UtilisateurRepository(Connection connection)
        {
            _connection = connection;
        }

        public int Create(Utilisateur user)
        {
            Command cmd = new Command("Create_Utilisateur", true) ;
            cmd.AddParameter("civilite", user.Civilite);
            cmd.AddParameter("nom", user.Nom);
            cmd.AddParameter("prenom", user.Prenom);
            return _connection.ExecuteNonQuery(cmd);
        }
        public IEnumerable<Utilisateur> GetAll()
        {
            Command cmd = new Command("Select * from Utilisateur");
            return _connection.ExecuteReader(cmd, reader => new Utilisateur()
            {
                UtilisateurID = (int)reader["UtilisateurId"],
                Nom = reader["Nom"].ToString(),
                NumFax = reader["NumFax"] is DBNull ? null : reader["NumFax"].ToString(),
            });

        }
    }
}
