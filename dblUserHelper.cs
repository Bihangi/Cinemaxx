using CinemaxxDuplicate.Classes;
using CinemaxxDuplicate.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaxxDuplicate
{
    internal class dbUserHelper
    {
        private string connectionString = "Data Source=DESKTOP-VBH9USN;Initial Catalog=Cinemaxx;Integrated Security=True";


        // Method to get all users
        public DataTable GetAllUsers()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username, Password, Email, ContactNumber, Role FROM [User]";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }


        //To get customer id by username
        public int GetUserIdByUsername(string username)
        {
            int userId = -1; 

            string query = "SELECT UserID FROM [User] WHERE Username = @Username";

            
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", username);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    userId = (int)reader["UserID"]; 
                }

                reader.Close();
            }

            return userId; 
        }



        // Method to get user by ID
        public DataRow GetUserById(int userId)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username, Password, Email, ContactNumber, Role FROM [User] WHERE UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userId);
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            return null; 
        }



        // Method to create a user
        public bool CreateUser(User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO [User] (Username, Password, Email, ContactNumber, Role) VALUES (@Username, @Password, @Email, @ContactNumber, @Role)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@ContactNumber", user.ContactNumber);
                        command.Parameters.AddWithValue("@Role", user.Role);

                        int count = command.ExecuteNonQuery();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        // Method to update user
        public bool UpdateUser(User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE [User] SET Username = @Username, Password = @Password, Email = @Email, ContactNumber = @ContactNumber, Role = @Role WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@UserID", user.UserID);
                        command.Parameters.AddWithValue("@Username", user.Username);
                        command.Parameters.AddWithValue("@Password", user.Password);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@ContactNumber", user.ContactNumber);
                        command.Parameters.AddWithValue("@Role", user.Role);

                        int count = command.ExecuteNonQuery();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }



        // Method to delete user
        public bool DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM [User] WHERE UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        int count = command.ExecuteNonQuery();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        // Method to login a user and return the user or admin object
        public Person Login(string username, string password, Form loginForm)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, Username, Role, Email, ContactNumber FROM [User] WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            if (dataTable.Rows.Count > 0)
            {
                DataRow userRow = dataTable.Rows[0];
                int userID = Convert.ToInt32(userRow["UserID"]);
                string role = userRow["Role"].ToString().Trim();

                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("No role assigned to user.");
                    return null;
                }

                if (!((LoginForm)loginForm).IsRoleSelected())
                {
                    MessageBox.Show("Please select a role (Admin or User).");
                    return null;
                }

                Person user;

                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    user = new Admin(userID, userRow["Username"].ToString(), string.Empty, userRow["Email"].ToString(), userRow["ContactNumber"].ToString(), role);
                }
                else if (role.Equals("User", StringComparison.OrdinalIgnoreCase))
                {
                    user = new User(userID, userRow["Username"].ToString(), string.Empty, userRow["Email"].ToString(), userRow["ContactNumber"].ToString(), role);
                }
                else
                {
                    MessageBox.Show("Invalid role assigned.");
                    return null;
                }

                SessionManager.CurrentUsername = userRow["Username"].ToString();
                SessionManager.CurrentUserId = userID;

                // Display appropriate dashboard based on role
                if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                {
                    AdminDashboardForm adminDashboard = new AdminDashboardForm();
                    MessageBox.Show("Welcome Admin!");
                    adminDashboard.Show();
                    loginForm.Close(); 
                }
                else if (role.Equals("User", StringComparison.OrdinalIgnoreCase))
                {
                    UserDashboardForm userDashboard = new UserDashboardForm();
                    MessageBox.Show("Welcome User!");
                    userDashboard.Show();
                    loginForm.Close(); 
                }

                return user;
            }
            else
            {
                MessageBox.Show("Invalid login details.");
                return null;
            }
        }

    }
}
