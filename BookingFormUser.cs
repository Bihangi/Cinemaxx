using CinemaxxDuplicate.Classes;
using System;
using System.Windows.Forms;

namespace CinemaxxDuplicate.Forms
{
    public partial class BookingFormUser : Form
    {
        private int selectedMovieID;
        private DateTime selectedMovieTime;

        private readonly dbMovieHelper movieHelper = new dbMovieHelper();
        private readonly dbBookingHelper bookingHelper = new dbBookingHelper();


        // Constructor to receive selected movie ID and time
        public BookingFormUser(int movieID, DateTime movieTime)
        {
            InitializeComponent();
            this.selectedMovieID = movieID;
            this.selectedMovieTime = movieTime;

            // Auto-fill the selected movie information on load
            var movieInfo = movieHelper.GetMovieDetails(movieID);
            if (movieInfo.Item1) 
            {
                textBoxMovie.Text = movieInfo.Item2;
                textBoxMovieID.Text = movieID.ToString();
            }

            // Auto-fill current user information using the SessionManager
            textBoxUsername.Text = SessionManager.CurrentUsername;
            textBoxUserID.Text = SessionManager.CurrentUserId.ToString();
        }


        private void BookingFormUser_Load(object sender, EventArgs e)
        {
            
        }


        // Booking button logic
        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (selectedMovieID == 0)
            {
                MessageBox.Show("Please select a valid movie.");
                return;
            }

            int userID = SessionManager.CurrentUserId;
            string username = SessionManager.CurrentUsername;

            if (userID == 0)
            {
                MessageBox.Show("Please enter a valid username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxMovie.Text) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }


            // Proceed with booking creation
            int bookingID;
            bool isBookingCreated = bookingHelper.CreateBooking(
                userID,
                selectedMovieID,
                username,
                textBoxMovie.Text,
                selectedMovieTime,
                out bookingID);

            if (isBookingCreated)
            {
                MessageBox.Show($"Booking ID {bookingID} created successfully. Your booking is pending and you will be notified to pay 24 hrs before the show.");
            }
            else
            {
                MessageBox.Show("Booking could not be created.");
            }
        }



        // Logout button 
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LogoutAndRedirect();
        }


        private void LogoutAndRedirect()
        {
            this.Hide();
            using (LoginForm loginForm = new LoginForm())
            {
                loginForm.ShowDialog();
            }
            this.Close();
        }


        //Back Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (MoviesFormUser moviesForm = new MoviesFormUser())
            {
                moviesForm.ShowDialog();
            }
            this.Close();
            
        }

        private void ClearInputs()
        {
            textBoxUsername.Clear();
            textBoxUserID.Clear();
            textBoxMovie.Clear();
            textBoxMovieID.Clear();
        }
    }
}
