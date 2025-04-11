using System;
using System.Windows.Forms;

namespace CinemaxxDuplicate.Classes
{
    internal class Booking
    {
        public User Username { get; set; }
        public int UserID { get; set; }
        public Movie MovieName { get; set; }
        public Movie MovieID { get; set; }
        public DateTime MovieDate { get; set; }
        public string Status { get; set; }


        private readonly dbBookingHelper bookingHelper = new dbBookingHelper();

        public void CreateBooking(int userID, int movieID, string username, string movieName, DateTime movieDate) { }
        public void DeleteBooking(int bookingID) { }
        public void UpdateBookingStatus(int bookingID, string status) { }

    }
}
