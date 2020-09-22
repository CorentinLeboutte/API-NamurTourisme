using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories

    /* Créer des méthodes qui vont faire le lien entre notre consommation et va aller
     chercher les données et celles-ci vont nous retourner les données qui seront dans la consommation*/
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private Connection _connection;
        public UtilisateurRepository(Connection connection)
        {
            _connection = connection;

        }


        //CREATE

        public int Create(Utilisateur user)
        {
            Command cmd = new Command("Create_Utilisateur", true);
            cmd.AddParameter("civilite", user.Civilite);
            cmd.AddParameter("nom", user.Nom);
            cmd.AddParameter("prenom", user.Prenom);
            cmd.AddParameter("dateNaiss", user.DateNaiss);
            cmd.AddParameter("numTelDomicile", user.NumTelDomicile);
            cmd.AddParameter("numTelPortable", user.NumTelPortable);
            cmd.AddParameter("numFax", user.NumFax);
            cmd.AddParameter("eMail", user.EMail);
            cmd.AddParameter("mdp", user.Mdp);
            cmd.AddParameter("adresseId", user.AdresseID);

            int Success = 0;
            try
            {
                _connection.ExecuteNonQuery(cmd);
            }
            catch(SqlException ex) 
            {
                if (ex.Message.Contains(""))
                    return Success = 1;
            }
            return Success;
        }

        //DELETE

        public void Delete(int Id)
        {
            Command cmd = new Command("Delete_Utilisateur", true);
            cmd.AddParameter("utilisateurID", Id);
            _connection.ExecuteNonQuery(cmd);
        }

        //GET

        public IEnumerable<Utilisateur> Get()
        {
            Command cmd = new Command("Select * from Utilisateur");
            return _connection.ExecuteReader(cmd, reader => new Utilisateur()
            {
                UtilisateurID = (int)reader["UtilisateurId"],
                Civilite = reader["Civilite"].ToString(),
                Nom = reader["Nom"].ToString(),
                Prenom = reader["Prenom"].ToString(),
                DateNaiss = (DateTime)reader["DateNaiss"],
                NumTelDomicile = reader["NumTelDomicile"] is DBNull ? null : reader["NumTelDomicile"].ToString(),
                NumTelPortable = reader["NumTelportable"].ToString(),
                NumFax = reader["NumFax"] is DBNull ? null : reader["NumFax"].ToString(),
                EMail = reader["EMail"].ToString(),
                AdresseID = (int)reader["AdresseId"]

            });

        }

        //GETBYID

        public Utilisateur GetById(int Id)
        {
            Command cmd = new Command("Select * from Utilisateur WHERE UtilisateurID = @Id");
            cmd.AddParameter("Id", Id);

            return _connection.ExecuteReader(cmd, reader => new Utilisateur()
            {
                UtilisateurID = (int)reader["UtilisateurId"],
                Civilite = reader["Civilite"].ToString(),
                Nom = reader["Nom"].ToString(),
                Prenom = reader["Prenom"].ToString(),
                DateNaiss = (DateTime)reader["DateNaiss"],
                NumTelDomicile = reader["NumTelDomicile"] is DBNull ? null : reader["NumTelDomicile"].ToString(),
                NumTelPortable = reader["NumTelportable"].ToString(),
                NumFax = reader["NumFax"] is DBNull ? null : reader["NumFax"].ToString(),
                EMail = reader["EMail"].ToString(),
                AdresseID = (int)reader["AdresseId"]
            }).SingleOrDefault();
        }

        //UPDATE

        public int Update(Utilisateur user)
        {
            Command cmd = new Command("Update_Utilisateur", true);
            cmd.AddParameter("UtilisateurId", user.UtilisateurID);
            cmd.AddParameter("civilite", user.Civilite);
            cmd.AddParameter("nom", user.Nom);
            cmd.AddParameter("prenom", user.Prenom);
            cmd.AddParameter("dateNaiss", user.DateNaiss);
            cmd.AddParameter("numTelDomicile", user.NumTelDomicile);
            cmd.AddParameter("numTelPortable", user.NumTelPortable);
            cmd.AddParameter("numFax", user.NumFax);
            cmd.AddParameter("eMail", user.EMail);
            cmd.AddParameter("mdp", user.Mdp);

            int success = 0;
            try
            {
                _connection.ExecuteNonQuery(cmd);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains(""))
                    return success = 1;
            }

            return success;

        }

    }
}
