using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Dates

            DateTime today = DateTime.Now;
            var notToday = new DateTime(1988, 02, 19).Month;
            Console.WriteLine("{0:dddd/MMMM/yyyy} year", today);
            Console.WriteLine(notToday);
            Console.WriteLine(DateTime.Now.AddMonths(4));
            #endregion

            #region Strings

            //var number = 100000000;
            //var currency = 25;
            //Console.WriteLine(String.Format("{0, -20:N} {1:P}", number, currency));

            //string sedc = "Hello from SEDC Academy v7.0";
            //Console.Write("Enter a range to cut the string: ");
            //string input = Console.ReadLine();
            //int range;
            //bool isNumber = int.TryParse(input, out range);
            //Console.WriteLine(SayMyName("Jontra", "Volta"));
            //Console.WriteLine(SomeString());
            //Console.WriteLine(WhereAmI());
            #endregion

            #region methods
            //string myName = MyName("Igor", "Mitkovski");
            //Console.WriteLine(myName);
            //string op;

            //do
            //{
            //    Console.Write("Enter the first number: ");
            //    int first = int.Parse(Console.ReadLine());
            //    Console.Write("Enter the second number: ");
            //    int second = int.Parse(Console.ReadLine());
            //    Console.Write("Enter '+' or '-': ");
            //    op = Console.ReadLine();
            //    if (op == "+")
            //    {
            //        Console.Write(Sum(first, second));
            //        break;
            //    } else if (op == "-")
            //    {
            //        Console.Write(Subtract(first, second));
            //        break;
            //    } else
            //    {
            //        Console.WriteLine("Please enter + or -");
            //    }
            //} while (op != "+" || op != "-");
            #endregion


            Console.ReadLine();
        }

        public static string SayMyName(string name, string lastName)
        {
            return $"My name is {name} and my last name is {lastName}";
        }

        public static string GetPartOfString(string str, int range)
        {
            if (range > 0 && range <= str.Length)
            {
                return str.Substring(0, range);
            } else
            {
                return str;
            }
        }

        public static string WhereAmI()
        {
            return @"C:\\Users\""igor.mitkovski""\Desktop\igor\Class4";
        }

        public static string SomeString()
        {
            return "Check your C:\\ drive \n" +
                "We will have \"fair\" elections";
        }

        public static int Sum(int first, int second, int thrid)
        {
            return first + second + thrid;
        }
        public static int Sum(int first, int second)
        {
            return first + second;
        }
        public static int Subtract(int first, int second)
        {
            return first - second;
        }


        public static string MyName(string name, string lastName)
        {
            return name + " " + lastName;
        }
    }
}
