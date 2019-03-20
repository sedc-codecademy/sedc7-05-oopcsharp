using CinemaLib.Entities;
using CinemaLib.Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region examples
            //try
            //{
            //    int result = DivideTwoNums();
            //    Console.WriteLine(result);
            //}
            //catch (FormatException e)
            //{

            //    Console.WriteLine("Format Exception: " +
            //        "You entered a character" +
            //        " which is not a number");
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine("Divide by zero ex: " +
            //        "You tried divison with zero");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            List<Movie> movieList = GenerateMovies.GenerateFirstList();

            Cinema Cineplexx = new Cinema("Cineplexx", new List<int> { 1, 2, 3, 4 }, movieList);

            Console.WriteLine("Got to end");
            Console.ReadLine();
        }

        public static int DivideTwoNums()
        {
            Console.Write("Enter a number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int second = int.Parse(Console.ReadLine());
            if (first < 0)
            {
                new Exception();
                throw new Exception("You entered a negative number");
            }
            return first / second;
        }
    }
}
