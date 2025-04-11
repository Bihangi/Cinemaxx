using System;

namespace CinemaxxDuplicate.Classes
{
    public class Movie
    {
        public int MovieID { get; private set; }
        public string MovieName { get; private set; }
        public string Genre { get; private set; }
        public DateTime MovieDate { get; private set; }
        public TimeSpan MovieTime { get; private set; }
        public string Availability { get; private set; }

        // Constructor for creating a new movie
        public Movie(string movieName, string genre, DateTime date, TimeSpan time, string availability)
        {
            MovieName = movieName;
            Genre = genre;
            MovieDate = date;
            MovieTime = time;
            Availability = availability;
        }


        // Constructor for loading an existing movie
        public Movie(int movieID, string movieName, string genre, DateTime date, TimeSpan time, string availability)
        {
            MovieID = movieID;
            MovieName = movieName;
            Genre = genre;
            MovieDate = date;
            MovieTime = time;
            Availability = availability;
        }

        // Method to update movie details
        public void UpdateMovieDetails(string movieName, string genre, DateTime date, TimeSpan time, string availability)
        {
            MovieName = movieName;
            Genre = genre;
            MovieDate = date;
            MovieTime = time;
            Availability = availability;
        }

        // Method to check if movie is available for booking
        public bool IsAvailable()
        {
            return Availability.ToLower() == "available";
        }
    }
}
