using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Entities;

namespace Demo
{
    class Program
    {
        static void HumanSkill(Human human)
        {
            try
            {
                foreach (Skill item in human.Skills)
                {
                    Console.WriteLine(item);
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("HumanSkill Function Exception");
                Console.WriteLine(ex.Message);
            }
        }
        static void HumanSkill2(Human human)
        {
            foreach (Skill item in human.Skills)
            {
                Console.WriteLine(item);
            }
        }
        static void HumanSkill3(Human human)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int x = Int32.Parse(Console.ReadLine());
                foreach (Skill item in human.Skills)
                {
                    Console.WriteLine(item);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("HumanSkill3 Function Exception");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("HumanSkill3 Function Exception");
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteToFileOrDatabase(string text)
        {
            try
            {
                Console.WriteLine("Open file OR database connection here");
                int x = Int32.Parse(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("WriteToFileOrDatabase");
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("Close file OR database connection here");
            }
        }

        static void Method1()
        {
            Console.WriteLine("Entering Method1...");
            Method2();
            Console.WriteLine("Exiting Method1...");
        }
        static void Method2()
        {
            Console.WriteLine("Entering Method2...");
            Method3();
            Console.WriteLine("Exiting Method2...");
        }
        static void Method3()
        {
            Console.WriteLine("Entering Method3...");
            try
            {
                int x = Int32.Parse("1m3");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Method3 Exception");
                Console.WriteLine(ex.Message);
            }
            //int x = Int32.Parse("1m3");
            Console.WriteLine("Exiting Method3...");
        }

        static void Main(string[] args)
        {
            #region INFO
            //A bug is a programmer mistake that should be fixed before the code is made available to users.

            //Exceptions are raised as a result of problems that you can predict, but can’t prevent,
            //because they depend on factors outside your program.A network connection dropping suddenly, or running out of disk space...

            //An error is caused by user action. The user might enter a number where a letter is expected.
            //An error might cause an exception, but you can prevent that by implementing code to validate user input
            #endregion

            #region Without Exception

            //Console.WriteLine("Enter a number");
            //int number = Int32.Parse(Console.ReadLine());
            //Console.WriteLine($"You enter number: {number}");
            //Console.WriteLine("Finnaly code");

            #endregion

            #region Exception Example
            //Console.WriteLine("Enter a number");
            //try
            //{
            //    int number = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine($"You enter number: {number}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Finnaly code");
            //}
            #endregion

            #region Custom Exception
            //Console.WriteLine("Enter the letter a or b");
            //try
            //{
            //    string letter = Console.ReadLine();
            //    letter = letter.ToLower().Trim();
            //    if (letter == "a" || letter == "b")
            //    {
            //        Console.WriteLine($"You enter letter: {letter}");
            //    }
            //    else
            //    {
            //        Exception customException = new Exception("This letter is not a or b");
            //        customException.HelpLink = "google.com";
            //        throw customException;
            //        //throw new Exception("This letter is not a or b");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Custom Exception 2
            //Console.WriteLine("Enter the letter a or b");
            //try
            //{
            //    string letter = Console.ReadLine();
            //    letter = letter.ToLower().Trim();
            //    if (letter == "a" || letter == "b")
            //    {
            //        Console.WriteLine($"You enter letter: {letter}");
            //    }
            //    else
            //    {
            //        CustomException customException = new CustomException("This letter is not a or b");
            //        customException.HelpLink = "google.com";
            //        customException.CustomDescription = "asdasdasdasd";
            //        throw customException;
            //        //throw new CustomException("This letter is not a or b");
            //    }
            //}
            //catch (CustomException ex)
            //{
            //    Console.WriteLine("Custom Exception");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.CustomDescription);
            //    Console.WriteLine(ex.HelpLink);
            //    Console.WriteLine(ex.StackTrace);
            //}
            #endregion

            #region Specific Exceptions
            //Console.WriteLine("Enter a number");
            //try
            //{
            //    int number = Int32.Parse(Console.ReadLine());
            //    number = number / 0;
            //    Console.WriteLine($"You enter a number: {number}");
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Overflow exception");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format exception");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General exception");
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            #region Inside Function Exception
            //Human h = new Human();
            //h.Name = "Bob";
            //HumanSkill(h);
            #endregion

            #region Exception to the higher level
            //try
            //{
            //    Human h = new Human();
            //    h.Name = "Bob";
            //    HumanSkill2(h);
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine("Exception to the higher level");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            #endregion

            #region Selective Exception handling
            //try
            //{
            //    Human h = new Human();
            //    h.Name = "Bob";
            //    HumanSkill3(h);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Overflow Exception to the higher level");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("General Exception to the higher level");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            #endregion

            #region BestPractice to close file OR DB connection in finally block
            //WriteToFileOrDatabase("1fd");
            #endregion

            #region BestPractice 2 place exception handlers as close as you can to the exception
            //try
            //{
            //    Method1();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Method1();
            #endregion

            Console.WriteLine("\nPress any key to exit");
            Console.ReadLine();
        }
    }
}
