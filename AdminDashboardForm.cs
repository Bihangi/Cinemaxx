using CinemaxxDuplicate.Classes;
using System;
using System.Windows.Forms;

namespace CinemaxxDuplicate.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private Admin _currentAdmin; 

        public AdminDashboardForm() 
        {
            InitializeComponent();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Open Booking Management Page
        private void buttonBookings_Click(object sender, EventArgs e)
        {
            OpenForm(new BookingFormAdmin(_currentAdmin));
            this.Close();
        }


        //Open Movie Management Page
        private void buttonMovies_Click(object sender, EventArgs e)
        {
            OpenForm(new MoviesFormAdmin(_currentAdmin));
            this.Close();
        }


        //Open User Management Page
        private void buttonUsers_Click(object sender, EventArgs e)
        {
            
            OpenForm(new UsersFormAdmin(_currentAdmin));
            this.Close();
        }


        //Logout button
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutAndRedirect();
        }


        private void LogoutAndRedirect()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Close();
        }

        private void OpenForm(Form form)
        {
            this.Hide();
            form.ShowDialog();
        }
    }
}
