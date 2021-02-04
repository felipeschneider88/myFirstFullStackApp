using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessCore.persistence
{
    class Queries
    {
        public Queries()
        {

        }
        public string FindGroupByName()
        {
            return "SELECT Id, name, description FROM groups WHERE name = @name";
        }

        public string FindUserIdByLogin()
        {
            return "SELECT Id, email, type FROM users WHERE email = @email and password = crypt( @password, password)";
        }

        public string InsertUser()
        {
            return "INSERT INTO users (email, password, type) "
                + "VALUES ( @email, crypt(@password, gen_salt('bf')), @type::userType)";
        }
        public string ValidUser()
        {
            //TODO: COnvert to SP
            return "SELECT count(Id) FROM users WHERE email = @email and password = crypt( @password, password)";
        }

        //TODO: This method need to be run using cascade deleting or at the end of the clean up
        //first need to delete the relation with the groups and/or the documents
        public string DeleteUser()
        {
            return "delete FROM users WHERE email = @email";
        }
        

    }
}
