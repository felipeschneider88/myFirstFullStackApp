using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessCore.persistence
{
    class ConnectionSQL : IConnection
    {
        private SqlConnection conn = null;

        public ConnectionSQL (SqlConnection pConnection)
        {
            conn = pConnection;
        }

        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
