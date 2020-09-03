using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories
{
    public class TypeThemeRepository
    {
        private Connection _connection;
        public TypeThemeRepository(Connection connection)
        {
            _connection = connection;
        }

    }
}
