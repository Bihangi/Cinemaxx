using CinemaxxDuplicate.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaxxDuplicate
{
    public partial class UserDashboardForm : Form
    {
        public UserDashboardForm()
        {
            InitializeComponent();
        }

        private void UserDashboardForm_Load_1(object sender, EventArgs e)
        {

        }


        //Load Booking Form
        private void buttonViewBookings_Click(object sender, EventArgs e)
        {
            int selectedMovieID = 1; 
            DateTime selectedMovieTime = DateTime.Now; 

            OpenForm(new BookingFormUser(selectedMovieID, selectedMovieTime));
        }


        private void OpenForm(Form form)
        {
            this.Hide(); 
            form.ShowDialog(); 
        }


        private void LogoutAndRedirect()
        {
            this.Hide(); 
            LoginForm loginForm = new LoginForm(); 
            loginForm.ShowDialog(); 
            this.Close(); 
        }


        //Logout Button
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LogoutAndRedirect();
        }


        //Load Movie Form
        private void buttonViewMovies_Click(object sender, EventArgs e)
        {
            OpenForm(new MoviesFormUser());
        }
    }
}
