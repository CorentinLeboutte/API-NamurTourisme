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
    public class ThemeRepository : IThemeRepository
    {
        private Connection _connection;
        public ThemeRepository(Connection connection)
        {
            _connection = connection;
        }

        //CREATE


        public int Create(Theme theme)
        {
            Command cmd = new Command("Create_Theme", true);
            cmd.AddParameter("nom", theme.Nom);
            cmd.AddParameter("description", theme.Description);
            cmd.AddParameter("heureOuverture", theme.HeureOuverture);
            cmd.AddParameter("heureFermeture", theme.HeureFermeture);
            cmd.AddParameter("lienSiteWeb", theme.LienSiteWeb);

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
            Command cmd = new Command("Delete_Theme", true);
            cmd.AddParameter("themeID", Id);
            _connection.ExecuteNonQuery(cmd);
        }

        //GET

        public IEnumerable<Theme> GetAll()
        {
            Command cmd = new Command("Select * from Theme");
            return _connection.ExecuteReader(cmd, reader => new Theme()
            {
                ThemeID = (int)reader["UtilisateurId"],
                Nom = reader["nom"].ToString(),
                Description = reader["description"].ToString(),
                HeureOuverture = reader["DateNaiss"] is DBNull ? null : (DateTime?)reader["heureOuverture"],
                HeureFermeture = reader["DateNaiss"] is DBNull ? null : (DateTime?)reader["heureOuverture"],
                LienSiteWeb = reader["lienSiteWeb"] is DBNull ? null : reader["lienSiteWeb"].ToString(),
            });

        }

        //GETBYID

        public Theme GetById(int Id)
        {
            Command cmd = new Command("Select * from Theme WHERE ThemeID = @Id");
            cmd.AddParameter("Id", Id);

            return _connection.ExecuteReader(cmd, reader => new Theme()
            {
                ThemeID = (int)reader["UtilisateurId"],
                Nom = reader["nom"].ToString(),
                Description = reader["description"].ToString(),
                HeureOuverture = reader["DateNaiss"] is DBNull ? null : (DateTime?)reader["heureOuverture"],
                HeureFermeture = reader["DateNaiss"] is DBNull ? null : (DateTime?)reader["heureOuverture"],
                LienSiteWeb = reader["lienSiteWeb"] is DBNull ? null : reader["lienSiteWeb"].ToString(),

            }).SingleOrDefault();
        }

        //UPDATE

        public int Update(Theme theme)
        {
            Command cmd = new Command("Update_Theme", true);
            cmd.AddParameter("nom", theme.Nom);
            cmd.AddParameter("description", theme.Description);
            cmd.AddParameter("heureOuverture", theme.HeureOuverture);
            cmd.AddParameter("heureFermeture", theme.HeureFermeture);
            cmd.AddParameter("lienSiteWeb", theme.LienSiteWeb);
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
