using BusinessCore.persistence;
using BusinessCore.value_objects;
using myDocumentsCore.logic.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BusinessCore.logic.Users
{
    class DUsers
    {
        private Dictionary<string, User> Users;

        public DUsers ()
        {
            Users = new Dictionary<string, User>();
        }
        public void Insert(SqlConnection conn, VOUser VOUser)
        {
            Queries queries = new Queries();
            string insertUser = queries.InsertUser();
            SqlCommand insertCommand = new SqlCommand(insertUser, conn);
            insertCommand.Parameters.Add(
                new SqlParameter()
                {
                    ParameterName = "@email",
                    DbType = System.Data.DbType.String,
                    Value = VOUser.Email
                }
                );
            insertCommand.Parameters.Add(
                new SqlParameter()
                {
                    ParameterName = "@password",
                    DbType = System.Data.DbType.String,
                    Value = VOUser.Password
                }
                );
            insertCommand.Parameters.Add(
                new SqlParameter()
                {
                    //See how to cast enum in a proper way
                    ParameterName = "@type",
                    DbType = System.Data.DbType.String,
                    Value = VOUser.Type
                }
                ); ;
            insertCommand.ExecuteNonQuery();
        }

        public bool Member(SQLConnection conn, VOUser voU)
        {
            bool existe = false;
            if (Find(conn, voU) != null)
                existe = true;
            return existe;
        }
        public User Find(SQLConnection conn, VOUser voU)
        {
            User response = null;
            Queries queries = new Queries();
            string finduser = queries.FindUserIdByLogin();
            SqlCommand findCommand = new SqlCommand(finduser, conn);
            findCommand.Parameters.Add(
                new SqlParameter()
                {
                    ParameterName = "@email",
                    DbType = System.Data.DbType.String,
                    Value = voU.Email
                }
                );
            findCommand.Parameters.Add(
                    new SqlParameter()
                    {
                        ParameterName = "@password",
                        DbType = System.Data.DbType.String,
                        Value = voU.Password
                    }
                    );
            SqlDataReader reader = findCommand.ExecuteReader();

            while (reader.Read())
            {
                //public Integrante(int id, string nom, string ape, DateTime fechaNac)
                int id = (int)reader["id"];
                string email = reader["email"].ToString();
                int type = (int) reader["type"];
                response = new User(id, email, type);
            }
            reader.Close();
            return response;
        }

        public void Delete(SQLConnection conn, VOUser VOUser)
        {
            Queries consultas = new Queries();
            string deleteIntegrante = consultas.DeleteUser();
            SqlCommand deleteCommand = new SqlCommand(deleteIntegrante, conn);
            deleteCommand.Parameters.Add(
                new SqlParameter()
                {
                    ParameterName = "@email",
                    DbType = System.Data.DbType.String,
                    Value = VOUser.Email
                }
                );
            deleteCommand.ExecuteNonQuery();
        }
    }
}
