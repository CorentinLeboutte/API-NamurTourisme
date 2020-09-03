using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace ToolBoxDB
{
    public class Connection
    {
        private DbProviderFactory _Factory;

        private string _ConnectionString;

        public Connection(DbProviderFactory factory, ConnectionStringObj connectionString)
        {
            if (factory is null)
                throw new ArgumentNullException(nameof(factory));
            if (connectionString is null)
                throw new ArgumentNullException(nameof(factory));

            _Factory = factory;

            _ConnectionString = connectionString.ConnectionString;

            using (DbConnection co = CreateConnection())
            {
                co.Open();
            }
        }
        private DbConnection CreateConnection()
        {
            DbConnection co = _Factory.CreateConnection();
                co.ConnectionString = _ConnectionString;

            return co;
            
        }

        public DbCommand CreateCommand(DbConnection co, Command command)
        {
            DbCommand cmd = co.CreateCommand();

            cmd.CommandText = command.Query;

            if (command.IsStoredProcedure)
                cmd.CommandType = CommandType.StoredProcedure;

            foreach (KeyValuePair<string, object> KVP in command.Parameters)
            {
                DbParameter Pnom = _Factory.CreateParameter();
                Pnom.ParameterName = KVP.Key;
                Pnom.Value = KVP.Value;

                cmd.Parameters.Add(Pnom);
            }
            return cmd;
        }

        public object ExecuteScalar(Command command)
        {
            using (DbConnection Co = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(Co, command))
                {
                    Co.Open();
                    object o = cmd.ExecuteScalar();
                    Co.Close();
                    return (o is DBNull) ? null : o;  
                }
            }
        }

        public int ExecuteNonQuery(Command command)
        {
            using (DbConnection Co = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(Co, command))
                {
                    Co.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<TResult> ExecuteReader<TResult>(Command command, Func<IDataReader, TResult> selector)
        {
            if (selector is null)
                throw new ArgumentNullException(nameof(selector));

            using (DbConnection Co = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(Co,command))
                {
                    Co.Open();
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return selector(reader);
                        }
                    }
                }
            }
        }

        public DataTable GetDataTable(Command command)
        {
            using (DbConnection Co = CreateConnection())
            {
                using (DbCommand cmd = CreateCommand(Co, command))
                {
                    using (DbDataAdapter adapter = _Factory.CreateDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        return data;
                    }
                }
            }
        }
    }
}
