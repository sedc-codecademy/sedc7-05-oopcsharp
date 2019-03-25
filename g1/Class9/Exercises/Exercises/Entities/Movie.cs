using System;

namespace Exercises.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            try
            {
                if (rating > 0 && rating < 6)
                {
                    Rating = rating;
                }
                else
                {
                    throw new Exception("Rating must be from 1 to 5");
                }
            }
            catch (Exception ex)
            {
                this.Rating = 1;
                Console.WriteLine(ex.Message);
            }
            TicketPrice = Rating * 5;
        }
    }
}
