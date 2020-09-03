using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories
{
    public class ThemeRepository
    {
        private Connection _connection;
        public ThemeRepository(Connection connection)
        {
            _connection = connection;
        }

    }
}
