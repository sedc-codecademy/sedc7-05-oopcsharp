using CinemaLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaLib.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating)
        {
            Title = title;
            Genre = genre;
            try
            {
                if(rating < 0 || rating > 5)
                {
                    throw new Exception("Rating must be between 1 and 5");
                }
                Rating = rating;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            TicketPrice = 5 * Rating;
        }
    }
}
