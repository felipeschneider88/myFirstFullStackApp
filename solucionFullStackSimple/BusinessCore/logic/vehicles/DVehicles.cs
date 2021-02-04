using BusinessCore.persistence;
using BusinessCore.value_objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BusinessCore.logic.vehicles
{
    class DVehicles
    {
        private Dictionary<Guid, Vehicle> vheicles;

        public DVehicles()
        {
            vheicles = new Dictionary<Guid, Vehicle>();
        }

        //TODO: Need to add the Connegtion manager
        //TODO: See if going with the Abstrac Factory or for now go directly to a SQL Connection and after make the refactoring
        public void Insert(SqlConnection conn, VOVheicle VOUauxVehicle)
        {
            Queries queries = new Queries();
            string insertUser = queries.InsertUser();
            SqlCommand insertCommand = new SqlCommand(insertUser, conn);
            insertCommand.Parameters.Add(
                new SqlParameter()
                {
                    ParameterName = "@email",
                    DbType = System.Data.DbType.String,
                    //TODO: Change based on Vehicle parameters
                    Value = ""
                }
                );
            insertCommand.Parameters.Add(
                new SqlParameter()
                {
                    ParameterName = "@password",
                    DbType = System.Data.DbType.String,
                    //TODO: Change based on Vehicle parameters
                    Value = ""
                }
                );
            insertCommand.ExecuteNonQuery();
        }
        public bool Member(SqlConnection conn, VOVheicle auxVheicle)
        {
            bool existe = false;
            if (Find(conn, auxVheicle) != null)
                existe = true;
            return existe;
        }

        public Vehicle Find(SqlConnection conn, VOVheicle auxVheicle )
        {
            Vehicle reponse = null;

            return reponse;
        }
    }
}
