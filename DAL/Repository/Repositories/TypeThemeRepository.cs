using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories
{
    public class TypeThemeRepository : ITypeThemeRepository
    {
        private Connection _connection;
        public TypeThemeRepository(Connection connection)
        {
            _connection = connection;
        }

        //CREATE

        public int Create(TypeTheme typetheme)
        {
            Command cmd = new Command("Create_TypeTheme", true);
            cmd.AddParameter("nom", typetheme.Nom);
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
            Command cmd = new Command("Delete_TypeTheme", true);
            cmd.AddParameter("typeThemeID", Id);
            _connection.ExecuteNonQuery(cmd);
        }



        //GET

        public IEnumerable<TypeTheme> Get()
        {
            Command cmd = new Command("Select * from TypeTheme");
            return _connection.ExecuteReader(cmd, reader => new TypeTheme()
            {
                TypeThemeID = (int)reader["TypeThemeId"],
                Nom = reader["Nom"].ToString(),

            });

        }

        //GETBYID

        public TypeTheme GetById(int Id)
        {
            Command cmd = new Command("Select * from TypeTheme WHERE TypeThemeID = @Id");
            cmd.AddParameter("Id", Id);

            return _connection.ExecuteReader(cmd, reader => new TypeTheme()
            {
                TypeThemeID = (int)reader["TypeThemeId"],
                Nom = reader["Nom"].ToString(),
            }).SingleOrDefault();
        }

        //UPDATE
        public int Update(TypeTheme typetheme)
        {
            Command cmd = new Command("Update_Utilisateur", true);
            cmd.AddParameter("nom", typetheme.Nom);
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

        public IEnumerable<TypeTheme> GetByTheme(int id)
        {
            Command cmd = new Command("Select * from TypeTheme WHERE TypeThemeID in (select TypeThemeID from ThemeTypeTheme where themeID =@ID)");
            cmd.AddParameter("ID", id);

            return _connection.ExecuteReader(cmd, reader => new TypeTheme()
            {
                TypeThemeID = (int)reader["TypeThemeId"],
                Nom = reader["Nom"].ToString(),
            });
            
        }

    }
}
