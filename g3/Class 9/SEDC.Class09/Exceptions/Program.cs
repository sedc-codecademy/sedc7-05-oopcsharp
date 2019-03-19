using Exceptions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        // Exception handling inside a function ( lower level )
        static void humanSkill(Human human)
        {
            try
            {
                foreach (var item in human.Skills)
                {
                    Console.WriteLine(item.Name);
                }
            }
            catch (Exception ex)
            {
                Console.Write("Catch inside the function:" + ex.Message);
            }
        }
        // Exception handling propagation ( exception sent to the higher level )
        static void humanSkill2(Human human)
        {
            foreach (var item in human.Skills)
            {
                Console.WriteLine(item.Name);
            }
        }
        // Selective exception handling
        static void humanSkill3(Human human)
        {
            // This only catches 2 types of exception. All other exceptions will go to the upper level catch if there is any
            try
            {
                int x = Int32.Parse(Console.ReadLine());
                foreach (var item in human.Skills)
                {
                    Console.WriteLine(item.Name);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Inside the function - No refference to an object!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Inside the function - BROKE THE MEMORY AGAIN!");
            }
        }
        static void Main(string[] args)
        {
            // Exceptions 
            Console.WriteLine("Number Example");
            Console.WriteLine("Enter a number:");
            try
            {
                int number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("The number you entered is: " + number);
            }
            // Generic exception. All information are kept in ex variable so we can access them
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit from this function!");
                Console.ReadLine();
            }

            // Custom Exception ( Exception with our own logic )
            Console.WriteLine("Handling with custom messages");
            Console.WriteLine("enter the letter a or b");
            try
            {
                string letter = Console.ReadLine().ToLower().Trim();
                if (letter == "a" || letter == "b")
                {
                    Console.WriteLine("Congratulations, you have entered a or b!");
                }
                else
                {
                    // If this is not inside a try/catch it will break the application like any other exception
                    throw new Exception("That is not a or b! Sorry!");
                }

            }
            catch (Exception ex)
            {
                // Message
                Console.WriteLine(ex.Message);
                // This is an innerException message ( More details on the problem )
                Console.WriteLine("More info: " + ex.InnerException.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit from this function!");
                Console.ReadLine();
            }

            //Handling specific exceptions
            Console.WriteLine("Handling specific exceptions!");
            try
            {
                Console.WriteLine("enter some character!");
                char char1 = char.Parse(Console.ReadLine());
                Console.WriteLine("The character you entered is: " + char1);
                Console.WriteLine("enter some number now!");
                int int1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("The number you entered is: " + int1);

            }
            // This will fire only when the exception is OverflowException
            catch (OverflowException)
            {
                Console.WriteLine("You broke the memory!!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered something other than a character!");
            }
            finally
            {
                Console.WriteLine("Press any key to exit from this function!");
                Console.ReadLine();
            }
            // Catching exceptions from inside of a function
            try
            {
                humanSkill(new Human() { Name = "Bob" });
                humanSkill2(new Human() { Name = "Greg" });
                humanSkill3(new Human() { Name = "Bill" });
            }
            catch (Exception ex)
            {
                Console.Write("Catch outside the function:" + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
