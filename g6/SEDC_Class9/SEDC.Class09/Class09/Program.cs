using System;
using System.Collections.Generic;
using System.Linq;

namespace Class09
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> names = new List<string> { "Risto", "Martin" };

                string firstThatStartsWithC = names.FirstOrDefault(x => x.StartsWith("C"));
                firstThatStartsWithC.Contains("a");
                Console.WriteLine(firstThatStartsWithC);

                //string password = Console.ReadLine();

                //if (password.Length < 8)
                //{
                //    throw new Exception("Password is weak.");
                //}
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Name does not exist");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry we have a problem.");
            }
            finally
            {
                Console.WriteLine("Thanks for using our app.");
            }

            Console.Read();
        }
    }
}
