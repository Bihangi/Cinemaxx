using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaxxDuplicate
{
    internal class dbBookingHelper
    {
        public string connectionString = "Data Source=DESKTOP-VBH9USN;Initial Catalog=Cinemaxx;Integrated Security=True";


        //Method to create a Booking
        public bool CreateBooking(int userID, int movieID, string username, string movieName, DateTime movieDate, out int bookingID)
        {
            bookingID = 0; 
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO [Booking] (UserID, MovieID, Username, MovieName, BookingDate, Status) OUTPUT INSERTED.BookingID " +
                                   "VALUES (@UserID, @MovieID, @Username, @MovieName, @BookingDate, 'Pending')";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@MovieID", movieID);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@MovieName", movieName);
                        command.Parameters.AddWithValue("@BookingDate", movieDate);

                        bookingID = (int)command.ExecuteScalar();
                        return bookingID > 0; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating booking: " + ex.Message);
                return false; 
            }
        }


        //Method to delete a Booking
        public bool DeleteBooking(int bookingID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM [Booking] WHERE BookingID = @BookingID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BookingID", bookingID);
                        int count = command.ExecuteNonQuery();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting booking: " + ex.Message);
                return false;
            }
        }


        //Method to Update a Booking
        public bool UpdateBookingStatus(int bookingID, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE [Booking] SET Status = @Status WHERE BookingID = @BookingID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Status", status);
                        command.Parameters.AddWithValue("@BookingID", bookingID);

                        int count = command.ExecuteNonQuery();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking status: " + ex.Message);
                return false;
            }
        }


        
    }
}
