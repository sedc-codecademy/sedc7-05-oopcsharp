using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04_App
{
    class Program
    {
        //Method that returns void and has no input parameters
        static void CheckDroids()
        {
            Console.WriteLine("These aren't the droids that you are looking for.");
            Console.ReadLine();
        }

        //Method that returns void but has input parameter
        static void CheckDroids2(bool isJedi)
        {
            if (isJedi)
            {
                Console.WriteLine("These aren't the droids that you are looking for.");
            }
            else
            {
                Console.WriteLine("Take the droid, it's cool!");
            }
        }

        //Method that returns string with no input parameters
        static string SayMyName()
        {
            return "Hello from SEDC, we are learning C# and it's awesome!";
        }

        //Mehtods that returns int and has input paramters (Exercise 1 mehtod)
        static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        //Exercise 1
        static void Calculate()
        {
            Console.WriteLine("Enter operator (+ or -)");
            string sign = Console.ReadLine();

            if (sign != "+" && sign != "-")
            {
                Console.WriteLine("Sorry! Wrong input!");
            }

            Console.WriteLine("Enter the first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if (sign == "+")
                Console.WriteLine(Sum(firstNumber, secondNumber)); 
            if (sign == "-")
                Console.WriteLine(Sub(firstNumber, secondNumber)); 
        }

        //Method that returns bool and has one input paramter
        static bool IsAdmin(string role)
        {
            if (role == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Exercise 3
        static bool SubstringsExercise()
        {
            string a = "Hello from SEDC Codecademy v6.0";
            Console.WriteLine("Please enter a number");
            int result;

            if (Int32.TryParse(Console.ReadLine(), out result) != true)
            {
                Console.WriteLine("You have entered an incorrect format,\nPress any key to try again!");
                return false;
            }
            if (result > a.Length)
            {
                Console.WriteLine("You have entered an incorrect number,\nPress any key to try again!");
                return false;
            }
            
            string result1 = a.Substring(0, result);
            Console.WriteLine($"{result1} is the substring and the length is {result1.Length}");
            //Console.WriteLine(b);
            return true;
        }

        static void Main(string[] args)
        {
            #region Methods
            //CheckDroids();
            //CheckDroids2(false);
            //Console.WriteLine(SayMyName());

            //if (IsAdmin("Admin"))
            //{
            //    Console.WriteLine("Hello admin!");
            //}
            //else
            //{
            //    Console.WriteLine("Hello user!");
            //}

            //Calculate();

            #endregion


            #region Strings

            // 1. Concatination and interpolation of strings

            //Console.WriteLine("Check your C:\\ drive \"please!\" ");

            //string firstString = @"Check your C:\ drive";
            //string secondString = @"We will have a ""fair"" elections";
            //string thirdString = @"The \n sign means new line";

            //Console.WriteLine(firstString);
            //Console.WriteLine(secondString);
            //Console.WriteLine(thirdString);
            //int number = 10;
            //Console.WriteLine("This is the first string " + firstString);
            //Console.WriteLine("This is the first string {0} {2}", firstString, secondString, thirdString);
            //Console.WriteLine($"This is the first string {firstString} and the integer value is {number}");

            //string name = "Martin";
            //string lastName = "Panovski";

            //string myStringNumber = string.Format("{0:C}", 190);
            //string myStringPercent = string.Format("{0:P}", 1);
            //string myStringNumber1 = string.Format("{0:N}", 120);

            //string myPhone = string.Format("{0:0##-###-###}", 070222333);

            //string myStringAllignString1 = string.Format("|{0,10} | {1,10}", "Id", "Order");
            //string myStringAllignString2 = string.Format("|{0,10} | {1,10}", 25, "A box");

            //Console.WriteLine(myStringNumber);
            //Console.WriteLine(myStringPercent);
            //Console.WriteLine(myStringNumber1);
            //Console.WriteLine(myPhone);
            //Console.WriteLine(myStringAllignString1);
            //Console.WriteLine(myStringAllignString2);
            //Console.WriteLine("Hello {1} {0}", name, lastName);



            // 2. String Methods
            string ourString = "My name is Damjan!";
            //string toLowerString = ourString.ToLower();
            //string toUpperString = ourString.ToUpper();

            //Console.WriteLine($"Hello there! {toLowerString}");
            //Console.WriteLine($"Hello there! {toUpperString}");

            //string name = "       My name is Damjan!";
            //Console.WriteLine($"{name.Trim()}");

            char[] arrayString = ourString.ToCharArray();
            //Console.WriteLine(arrayString.Length);
            //Console.WriteLine(arrayString[4]);
            //Console.WriteLine(arrayString);

            //foreach (char item in arrayString)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] greetArray = { "Hello", "From", "SEDC" };

            //string message = String.Join(",", arrayString);
            //string message1 = String.Join(" ", arrayString);
            //string message2 = String.Join(".", arrayString);

            //Console.WriteLine(message);
            //Console.WriteLine(message1);
            //Console.WriteLine(message2);


            //Exercise 3
            //while (!SubstringsExercise())
            //{
            //    Console.ReadLine();
            //}

            #endregion


            #region DateTime

            //DateTime date = new DateTime();
            //Console.WriteLine(date);

            //DateTime newDate = new DateTime(1993, 08, 27);
            //Console.WriteLine(newDate);

            //string stringDate = "12-08-2012";
            //DateTime convertedDate = DateTime.Parse(stringDate);
            //Console.WriteLine(convertedDate);


            //DateTime currentDate = DateTime.Now;
            //int currentYear = currentDate.Year;
            //int currentMonth = currentDate.Month;
            //DateTime twoYearsFromNow = currentDate.AddYears(2);

            //Console.WriteLine(currentDate);
            //int today = DateTime.Today.Day;
            //Console.WriteLine(today);

            //DateTime addedDays = currentDate.AddDays(2);
            //DateTime subDays = currentDate.AddDays(-2);
            //Console.WriteLine(addedDays);
            //Console.WriteLine(subDays);


            //string dateFormated1 = currentDate.ToString("MM/dd/yyyy");
            //string dateFormated2 = currentDate.ToString("dddd, dd MMMM yyyy");
            //string dateFormated3 = string.Format("Today is {0:MM/dd/yy}, {0:dddd}", currentDate);
            //Console.WriteLine(dateFormated1);
            //Console.WriteLine(dateFormated2);
            //Console.WriteLine(dateFormated3);



            DateTime threeDaysFromNow = DateTime.Now.AddDays(3);
            DateTime oneMonthFromNow = DateTime.Now.AddMonths(1);
            DateTime oneMonthAndThreeDaysFromNow= DateTime.Now.AddMonths(1).AddDays(3);
            DateTime oneYearAndTwoMonthsAgo = DateTime.Now.AddYears(-1).AddMonths(-2);

            string currentMonthWithWords = DateTime.Now.ToString("MMM");

            Console.WriteLine(threeDaysFromNow);
            Console.WriteLine(oneMonthFromNow);
            Console.WriteLine(oneMonthAndThreeDaysFromNow);
            Console.WriteLine(oneYearAndTwoMonthsAgo);
            Console.WriteLine(currentMonthWithWords);


            #endregion
            
            Console.ReadLine();
        }


    }
}
