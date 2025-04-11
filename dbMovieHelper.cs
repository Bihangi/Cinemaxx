using CinemaxxDuplicate.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CinemaxxDuplicate
{
    public class dbMovieHelper
    {
        private string connectionString = "Data Source=DESKTOP-VBH9USN;Initial Catalog=Cinemaxx;Integrated Security=True";



        // Method to add a new movie to the database
        public bool AddMovie(Movie movie)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO [Movie] (MovieName, Genre, Date, Time, Availability) VALUES (@MovieName, @Genre, @Date, @Time, @Availability)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MovieName", movie.MovieName);
                        cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                        cmd.Parameters.AddWithValue("@Date", movie.MovieDate);
                        cmd.Parameters.AddWithValue("@Time", movie.MovieTime);
                        cmd.Parameters.AddWithValue("@Availability", movie.Availability);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding movie: " + ex.Message);
                return false;
            }
        }
        


        // Method to update an existing movie in the database
        public bool UpdateMovie(Movie movie)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE [Movie] SET MovieName = @MovieName, Genre = @Genre, Date = @Date, Time = @Time, Availability = @Availability WHERE MovieID = @MovieID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MovieID", movie.MovieID);
                        cmd.Parameters.AddWithValue("@MovieName", movie.MovieName);
                        cmd.Parameters.AddWithValue("@Genre", movie.Genre);
                        cmd.Parameters.AddWithValue("@Date", movie.MovieDate);
                        cmd.Parameters.AddWithValue("@Time", movie.MovieTime);
                        cmd.Parameters.AddWithValue("@Availability", movie.Availability);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating movie: " + ex.Message);
                return false;
            }
        }



        // Method to delete a movie from the database
        public bool DeleteMovie(int movieID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM [Movie] WHERE MovieID = @MovieID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MovieID", movieID);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting movie: " + ex.Message);
                return false;
            }
        }


        // Method to retrieve all movies from the database
        public DataTable GetAllMovies()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        "SELECT MovieID, MovieName, Genre, Date, Time, Availability FROM [Movie]", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching movies: " + ex.Message);
                return null;
            }
        }


        //Mehtod to get movie details
        public (bool, string) GetMovieDetails(int movieID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MovieName FROM [Movie] WHERE MovieID = @MovieID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MovieID", movieID);
                        var result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return (true, result.ToString()); 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching movie details: " + ex.Message);
            }
            return (false, string.Empty); 
        }


        // Method to validate if the movie can be booked and the user has agreed to the terms
        public static bool CanBookMovie(string availability, bool isAgreed)
        {
            if (string.IsNullOrWhiteSpace(availability) || availability.ToLower() != "available")
            {
                MessageBox.Show("The selected movie is not available.");
                return false;
            }

            if (!isAgreed)
            {
                MessageBox.Show("You must agree to the terms and conditions to proceed with booking.");
                return false;
            }

            return true;
        }
    }
}
