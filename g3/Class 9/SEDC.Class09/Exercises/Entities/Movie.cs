using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Entities
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, Genre genre, int rating, double ticketPrice)
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
                Console.WriteLine(ex.Message);
            }
            TicketPrice = Rating * ticketPrice;
        }
    }
}
