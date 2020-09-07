using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

            return _connection.ExecuteNonQuery(cmd);
        }

        //READ

        public IEnumerable<TypeTheme> GetAll()
        {
            Command cmd = new Command("Select * from TypeTheme");
            return _connection.ExecuteReader(cmd, reader => new TypeTheme()
            {
                TypeThemeID = (int)reader["TypeThemeId"],
                Nom = reader["Nom"].ToString(),

            });

        }

        //UPDATE
        public void Update(TypeTheme typetheme)
        {
            Command cmd = new Command("Update_Utilisateur", true);
            cmd.AddParameter("nom", typetheme.Nom);

        }


        //DELETE



    }
}
