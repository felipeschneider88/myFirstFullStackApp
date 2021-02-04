using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace BusinessCore.persistence
{
    class ConnectionManager
    {
        public SqlConnection Conexion
        {
            get
            {
                //TODO: Convert to setting based on the current type of connection
                // SQL Server
                //PostgresQL
                string connectionString =
                    ConfigurationManager.ConnectionStrings["ConnectionStringTalentoDB"].ConnectionString;
                //string connectionString = "Data Source=localhost;Initial Catalog=TalentosDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                return conn;
            }
        }
    }
}
