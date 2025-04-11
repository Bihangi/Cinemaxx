using System;
using System.Windows.Forms;

namespace CinemaxxDuplicate.Classes
{
    internal class User : Person
    {
        private readonly int _userID;
        private readonly dbBookingHelper bookingHelper = new dbBookingHelper();
        private readonly dbMovieHelper movieHelper = new dbMovieHelper();

        public int UserID => _userID;


        public User(int userID, string username, string password, string email, string contactNumber, string role)
            : base(userID, username, password, email, contactNumber, role)
        {
            _userID = userID;
        }

        public override void Login(string username, string password)
        {

        }

        public void BookMovie(int movieID, string movieName, DateTime movieDate)
        {
            int bookingID;
            if (bookingHelper.CreateBooking(this.UserID, movieID, this.Username, movieName, movieDate, out bookingID))
            {
                MessageBox.Show("Booking confirmed! Your booking ID is: " + bookingID);
            }
            else
            {
                MessageBox.Show("Booking failed!");
            }
        }

        public bool CreateUser(string username, string password, string email, string contactNumber, string role) 
        {
            return true;
        }

        public bool UpdateUser(string username, string password, string email, string contactNumber, string role)
        {
            return true;
        }

       
    }
}
