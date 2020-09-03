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
        


        //CREATE

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
            cmd.AddParameter("eMail", user.EMail);
            cmd.AddParameter("mdp", user.Mdp);

            
            return _connection.ExecuteNonQuery(cmd);
        }


        //READ

        public IEnumerable<Utilisateur> GetAll()
        {
            Command cmd = new Command("Select * from Utilisateur");
            return _connection.ExecuteReader(cmd, reader => new Utilisateur()
            {
                UtilisateurID = (int)reader["UtilisateurId"],
                Civilite= reader["Civilite"].ToString(),
                Nom = reader["Nom"].ToString(),
                Prenom = reader["Prenom"].ToString(),
                DateNaiss = (DateTime)reader["DateNaiss"],
                NumTelDomicile = reader["NumTelDomicile"] is DBNull ? null : reader["NumTelDomicile"].ToString(),
                NumTelPortable = reader["NumTelportable"].ToString(),
                NumFax = reader["NumFax"] is DBNull ? null : reader["NumFax"].ToString(),
                EMail = reader["EMail"].ToString(),
                Mdp = reader["mdp"].ToString(),
            });

        }

        //UPDATE

        public void Update(Utilisateur user)
        {
            Command cmd = new Command("Update_Utilisateur", true);
            cmd.AddParameter("civilite", user.Civilite);
            cmd.AddParameter("nom", user.Nom);
            cmd.AddParameter("prenom", user.Prenom);
            cmd.AddParameter("dateNaiss", user.DateNaiss);
            cmd.AddParameter("numTelDomicile", user.NumTelDomicile);
            cmd.AddParameter("numTelPortable", user.NumTelPortable);
            cmd.AddParameter("numFax", user.NumFax);
            cmd.AddParameter("eMail", user.EMail);
            cmd.AddParameter("mdp", user.Mdp);

        }

        //DELETE



    }
}
