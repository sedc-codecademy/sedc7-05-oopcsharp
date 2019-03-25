using CinemaLib.Entities;
using CinemaLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaLib.Generator
{
    public class GenerateMovies
    {
        public static List<Movie> GenerateFirstList()
        {
            return new List<Movie>
            {
                new Movie("Scary Movie", Genre.Comedy, 8),
                new Movie("American Pie", Genre.Comedy, 4),
                new Movie("Saw", Genre.Horror, 4),
                new Movie("The Shining", Genre.Horror, 4),
                new Movie("Rambo", Genre.Action, 3),
                new Movie("The Terminator", Genre.Action, 4),
                new Movie("Forrest Gump", Genre.Drama, 4),
                new Movie("12 Angru Men", Genre.Drama, 4),
                new Movie("Passengers", Genre.SciFi, 4),
                new Movie("Interstellar", Genre.SciFi, 4),
            };
        }
    }
}
