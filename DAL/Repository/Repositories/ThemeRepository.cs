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
            cmd.AddParameter("Nom", theme.Nom);
            cmd.AddParameter("Description", theme.Description);
            cmd.AddParameter("HeureOuverture", theme.HeureOuverture);
            cmd.AddParameter("HeureFermeture", theme.HeureFermeture);
            cmd.AddParameter("LienSiteWeb", theme.LienSiteWeb);

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

        public IEnumerable<Theme> Get()
        {
            Command cmd = new Command("Select * from Theme");
            return _connection.ExecuteReader(cmd, reader => new Theme()
            {
                ThemeID = (int)reader["ThemeID"],
                Nom = reader["Nom"].ToString(),
                Description = reader["Description"].ToString(),
                HeureOuverture = reader["HeureOuverture"] is DBNull ? null : (DateTime?)reader["HeureOuverture"],
                HeureFermeture = reader["HeureFermeture"] is DBNull ? null : (DateTime?)reader["HeureOuverture"],
                LienSiteWeb = reader["LienSiteWeb"] is DBNull ? null : reader["LienSiteWeb"].ToString(),
                AdresseID = (int)reader["AdresseId"]
            }) ;

        }

        //GETBYID

        public Theme GetById(int Id)
        {
            Command cmd = new Command("Select * from Theme WHERE ThemeID = @Id");
            cmd.AddParameter("Id", Id);

            return _connection.ExecuteReader(cmd, reader => new Theme()
            {
                ThemeID = (int)reader["themeId"],
                Nom = reader["Nom"].ToString(),
                Description = reader["Description"].ToString(),
                HeureOuverture = reader["HeureOuverture"] is DBNull ? null : (DateTime?)reader["HeureOuverture"],
                HeureFermeture = reader["HeureFermeture"] is DBNull ? null : (DateTime?)reader["HeureOuverture"],
                LienSiteWeb = reader["LienSiteWeb"] is DBNull ? null : reader["LienSiteWeb"].ToString(),
                AdresseID = (int)reader["AdresseId"]

            }).SingleOrDefault();
        }

        //UPDATE

        public int Update(Theme theme)
        {
            Command cmd = new Command("Update_Theme", true);
            cmd.AddParameter("Nom", theme.Nom);
            cmd.AddParameter("Description", theme.Description);
            cmd.AddParameter("HeureOuverture", theme.HeureOuverture);
            cmd.AddParameter("HeureFermeture", theme.HeureFermeture);
            cmd.AddParameter("LienSiteWeb", theme.LienSiteWeb);
            
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
