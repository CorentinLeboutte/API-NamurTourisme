using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories

    /* Créer des méthodes qui vont faire le lien entre notre consommation et va aller
     chercher les données et celles-ci vont nous retourner les données qui seront dans la consommation*/
{
    public class UtilisateurRepository
    {
        private Connection _connection;
        public UtilisateurRepository(Connection connection)
        {
            _connection = connection;

        }

        /* CRUD : Create Read Update Delete */
        // Méthode à générer : Read, create, update, delete

        public Utilisateur Get()
        {
            return new Utilisateur();
        }

        public int Create(Utilisateur user)
        {
            Command cmd = new Command("Create_Utilisateur", true) ;
            cmd.AddParameter("civilite", user.Civilite);
            cmd.AddParameter("nom", user.Nom);
            cmd.AddParameter("prenom", user.Prenom);
            cmd.AddParameter("dateNaiss", user.DateNaiss);
            cmd.AddParameter("numTelDomicile", user.NumTelDomicile);
            cmd.AddParameter("numTelPortable", user.NumTelPortable);
            cmd.AddParameter("numFax", user.NumFax);

            
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

        public int Update(Utilisateur user)
        {

        }

        public void Delete(int user)
        {

        }
    }
}
