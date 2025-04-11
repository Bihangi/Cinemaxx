using CinemaxxDuplicate.Forms;
using System;
using System.Windows.Forms;

namespace CinemaxxDuplicate.Classes
{
    public class Admin : Person 
    {
        
        private readonly dbUserHelper dbHelper = new dbUserHelper();
        private int _userID { get; set; }


        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }

        }


        public Admin(int userID, string username, string password, string email, string contactNumber, string role)
            : base(userID, username, password, email, contactNumber, role)                        
        { }



        // Add User
        public void CreateUser(string username, string password, string email, string contactNumber, string role)
        {
            User user = new User(0, username, password, email, contactNumber, role);
            bool result = dbHelper.CreateUser(user);
            if (result)
            {
                MessageBox.Show("User created successfully!");
            }
            else
            {
                MessageBox.Show("Failed to create user.");
            }
        }


        //Update User
        public void UpdateUser(int userID, string username, string password, string email, string contactNumber, string role)
        {
            User user = new User(userID, username, password, email, contactNumber, role);
            bool result = dbHelper.UpdateUser(user);
            if (result)
            {
                MessageBox.Show("User updated successfully!");
            }
            else
            {
                MessageBox.Show("Failed to update user!");
            }
        }



        //Delete User
        public void DeleteUser(int userID)
        {
            if (dbHelper.DeleteUser(userID))
            {
                MessageBox.Show("User deleted successfully.");
            }
            else
            {
                MessageBox.Show("Failed to delete user.");
            }
        }



        public override void Login(string username, string password) 
        {
           
        }
    }
}
