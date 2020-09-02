using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class ConnectionStringService
    {


        private string _connString;

        public string ConnString
        {
            get { return _connString; }
            set { _connString = @"Data Source=(localdb)\MSSQLLocalDB;
                                Initial Catalog = NamurTourismeDB; 
                                Integrated Security = True"; }
        }

    }
}
