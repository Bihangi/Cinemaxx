using System;

namespace CinemaxxDuplicate.Classes
{
    public abstract class Person
    {
        private int UserID { get; set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public string ContactNumber { get; private set; }
        public string Role { get; private set; }

        public Person(int userID, string username, string password, string email, string contactNumber, string role)
        {
            UserID = userID;
            Username = username;
            Password = password;
            Email = email;
            ContactNumber = contactNumber;
            Role = role;
        }

        public abstract void Login(string username, string password);
        
    }
}
