using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ToolBoxDB;

namespace DAL.Repository.Repositories
{
    public class PlanningRepository
    {
        private Connection _connection;
        public PlanningRepository(Connection connection)
        {
            _connection = connection;
        }

    }
}
