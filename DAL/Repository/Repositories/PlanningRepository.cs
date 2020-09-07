using DAL.Models;
using DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;
using System.Data.SqlClient;
using System.Linq;

namespace DAL.Repository.Repositories
{
    public class PlanningRepository : IPlanningRepository
    {
        private Connection _connection;
        public PlanningRepository(Connection connection)
        {
            _connection = connection;
        }

        //CREATE

        public int Create(Planning plan)
        {
            Command cmd = new Command("Create_Planning", true);
            cmd.AddParameter("date", plan.Date);
            cmd.AddParameter("heureDebut", plan.HeureDebut);
            cmd.AddParameter("heureFin", plan.HeureFin);

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

        public IEnumerable<Planning> GetAll()
        {
            Command cmd = new Command("Select * from Planning");
            return _connection.ExecuteReader(cmd, reader => new Planning()
            {
                PlanningID = (int)reader["planningId"],
                Date = (DateTime)reader["date"],
                HeureDebut = (DateTime)reader["heureDebut"],
                HeureFin = (DateTime)reader["heureFin"],
            });
        }


        //GETBYID

        public Planning GetById(int Id)
        {
            Command cmd = new Command("Select * from Planning WHERE PlanningID = @Id");
            cmd.AddParameter("Id", Id);

            return _connection.ExecuteReader(cmd, reader => new Planning()
            {
                PlanningID = (int)reader["planningId"],
                Date = (DateTime)reader["date"],
                HeureDebut = (DateTime)reader["heureDebut"],
                HeureFin = (DateTime)reader["heureFin"],

            }).SingleOrDefault();
        }

        //UPDATE

        public int Update(Planning plan)
        {
            Command cmd = new Command("Update_Planning", true);
            cmd.AddParameter("date", plan.Date);
            cmd.AddParameter("heureDebut", plan.HeureDebut);
            cmd.AddParameter("heureFin", plan.HeureFin);
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
