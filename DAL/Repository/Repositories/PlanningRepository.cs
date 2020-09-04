﻿using DAL.Models;
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

        //CREATE

        public int Create(Planning user)
        {
            Command cmd = new Command("Create_Planning", true);
            cmd.AddParameter("date", user.Date);
            cmd.AddParameter("heureDebut", user.HeureDebut);
            cmd.AddParameter("heureFin", user.HeureFin);

            return _connection.ExecuteNonQuery(cmd);
        }

        //READ

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

        //UPDATE

        public void Update(Planning user)
        {
            Command cmd = new Command("Update_Planning", true);
            cmd.AddParameter("date", user.Date);
            cmd.AddParameter("heureDebut", user.HeureDebut);
            cmd.AddParameter("heureFin", user.HeureFin);
         

        }

        //DELETE

       



    }
}
