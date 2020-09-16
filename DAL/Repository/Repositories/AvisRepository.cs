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
    public class AvisRepository : IAvisRepository
    {
        private Connection _connection;
        public AvisRepository(Connection connection)
        {
            _connection = connection;

        }


        //CREATE

        public int Create(Avis avis)
        {
            Command cmd = new Command("Create_Avis", true);
            cmd.AddParameter("note", avis.Note);
            cmd.AddParameter("commentaire", avis.Commentaire);
            cmd.AddParameter("dateCommentaire", avis.DateCommentaire);


            int Success = 0;
            try
            {
                _connection.ExecuteNonQuery(cmd);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains(""))
                    return Success = 1;
            }
            return Success;
        }

        //DELETE

        public void Delete(int Id)
        {
            Command cmd = new Command("Delete_Avis", true);
            cmd.AddParameter("avisID", Id);
            _connection.ExecuteNonQuery(cmd);
        }

        //GET

        public IEnumerable<Avis> Get()
        {
            Command cmd = new Command("Select * from Avis");
            return _connection.ExecuteReader(cmd, reader => new Avis()
            {
                AvisID = (int)reader["AvisId"],
                Note = (int)reader["Note"],
                Commentaire = reader["Commentaire"].ToString(),
                DateCommentaire = (DateTime)reader["DateCommentaire"],
            });

        }

        //GETBYID

        public Avis GetById(int Id)
        {
            Command cmd = new Command("Select * from Avis WHERE AvisID = @Id");
            cmd.AddParameter("Id", Id);

            return _connection.ExecuteReader(cmd, reader => new Avis()
            {
                AvisID = (int)reader["AvisId"],
                Note = (int)reader["Note"],
                Commentaire = reader["Commentaire"].ToString(),
                DateCommentaire = (DateTime)reader["DateCommentaire"],
            }).SingleOrDefault();
        }

        //UPDATE

        public int Update(Avis avis)
        {
            Command cmd = new Command("Update_Avis", true);
            cmd.AddParameter("note", avis.Note);
            cmd.AddParameter("commentaire", avis.Commentaire);
            cmd.AddParameter("dateCommentaire", avis.DateCommentaire);

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
