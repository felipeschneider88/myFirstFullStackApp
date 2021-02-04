using System;
using System.Collections.Generic;
using System.Text;

namespace myDocumentsCore.logic.Users
{
    class User
    {
        public int Id { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public User(int pID)
        {
            Id = pID;
        }
        public User(int pID, string pEmail)
        {
            Id = pID;
            Email = pEmail;
        }
        public User(int pID, string pEmail, int pUserType)
        {
            Id = pID;
            Email = pEmail;
            Type = pUserType;
        }
    }
}
