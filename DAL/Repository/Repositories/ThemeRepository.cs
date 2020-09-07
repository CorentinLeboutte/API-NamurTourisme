using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

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

            return _connection.ExecuteNonQuery(cmd);
        }

        //READ 

        public IEnumerable<Theme> GetAll()
        {
            Command cmd = new Command("Select * from Theme");
            return _connection.ExecuteReader(cmd, reader => new Theme()
            {
                ThemeID = (int)reader["UtilisateurId"],
                Nom = reader["nom"].ToString(),
                Description = reader["description"].ToString(),
                // HeureOuverture = (DateTime)reader["DateNaiss"] is DBNull ? null : (DateTime)reader["heureOuverture"],
                // HeureFermeture = (DateTime)reader["DateNaiss"] is DBNull ? null : (DateTime)reader["heureOuverture"],
                LienSiteWeb = reader["lienSiteWeb"] is DBNull ? null : reader["lienSiteWeb"].ToString(),
            });

        }

        //UPDATE

        public void Update(Theme theme)
        {
            Command cmd = new Command("Update_Theme", true);
            cmd.AddParameter("nom", theme.Nom);
            cmd.AddParameter("description", theme.Description);
            cmd.AddParameter("heureOuverture", theme.HeureOuverture);
            cmd.AddParameter("heureFermeture", theme.HeureFermeture);
            cmd.AddParameter("lienSiteWeb", theme.LienSiteWeb);

        }


        //DELETE

    }
}
