
namespace BusinessCore.value_objects
{
    class VOUser
    {
        public int Id { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }

        public VOUser(int pID, string pEmail, string pPassword)
        {
            Id = pID;
            Email = pEmail;
            Password = pPassword;
        }

        //Constructor to validate if the user exists
        public VOUser(string pEmail, string pPassword)
        {
            Email = pEmail;
            Password = pPassword;
        }
        public VOUser(string pEmail, string pPassword, int pUserType)
        {
            Email = pEmail;
            Password = pPassword;
            Type = pUserType;
        }
    }
}
