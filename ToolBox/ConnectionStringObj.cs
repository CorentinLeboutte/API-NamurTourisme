using System;
using System.Collections.Generic;
using System.Text;

namespace ToolBoxDB
{
    public class ConnectionStringObj
    {
        public string ConnectionString { get; private set; }

        public ConnectionStringObj(string ConnectionStringObj)
        {
            if (string.IsNullOrWhiteSpace(ConnectionStringObj))
                throw new ArgumentException(nameof(ConnectionStringObj));

            ConnectionString = ConnectionStringObj;
        }
    }
}
