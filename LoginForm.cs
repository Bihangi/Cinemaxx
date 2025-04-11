using CinemaxxDuplicate.Classes;
using CinemaxxDuplicate.Forms;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaxxDuplicate
{
    public partial class LoginForm : Form
    {
        private dbUserHelper userHelper;
        public string connectionString = "Data Source=DESKTOP-VBH9USN;Initial Catalog=Cinemaxx;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
            userHelper = new dbUserHelper();
        }


        // Login Button
        private void loginButton_Click_1(object sender, EventArgs e)
        {
            if (isLoggingIn) return; 

            isLoggingIn = true; 

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                isLoggingIn = false; 
                return;
            }

            // Call the login method
            Person user = userHelper.Login(username, password, this);

            if (!radioButtonAdmin.Checked && !radioButtonUser.Checked)
            {
                isLoggingIn = false;
                return;
            }

            string role = radioButtonAdmin.Checked ? "Admin" : "User";

            isLoggingIn = false;
        }



        public bool IsRoleSelected()
        {
            return radioButtonAdmin.Checked || radioButtonUser.Checked;
        }

        private bool isLoggingIn = false;



        private void LoginForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
