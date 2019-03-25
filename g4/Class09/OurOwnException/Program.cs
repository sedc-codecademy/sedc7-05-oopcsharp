using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurOwnException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Movie rambo = new Movie("First Blood");
                rambo.SetRating(8);
                Console.WriteLine(rambo);
            }
            catch (MovieException ex)
            {
                Console.WriteLine("Error entering rambo");
            }

            try
            {
                //int zero = int.Parse("zero");

                Movie theGodfather = new Movie("The Godfather");
                theGodfather.SetRating(20);
                Console.WriteLine(theGodfather);
            }
            catch (MovieException ex)
            {
                Console.WriteLine($"Error entering the Godfather: {ex.Message}");
            }

            Movie casablanca = new Movie("Casablanca");
            int rating = 100;
            if (rating > 0 && rating <= 10) {
                casablanca.SetRating(rating);
            }
            Console.WriteLine(casablanca);


        }
    }
}
