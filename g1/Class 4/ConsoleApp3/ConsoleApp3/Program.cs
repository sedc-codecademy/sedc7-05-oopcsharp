using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Test Funkcii
            /*
            Console.Write("Vnesi a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vnesi b: ");
            double b;
            double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Sumata na {0} + {1} = {2}", a, b, Suma(a, b));

            Console.WriteLine("------------");
            Console.Write("Vnesi x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vnesi y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Razlikata na {0} - {1} = {2}", x, y, Razlika(x, y));
            Console.WriteLine($"Razlikata na {x} - {y} = {Razlika(x, y)}");
            */
            #endregion

            #region Test strings 1
            /*
            Console.WriteLine("Vnesi nekoj string: ");
            string str = Console.ReadLine();
            Console.Write("Vensovte string: {0} ",str);
            Console.Write("\n");
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.Trim());
            Console.WriteLine(str.TrimStart());
            Console.WriteLine(str.TrimEnd());
            */
            #endregion

            #region Test strings 2
            /*
            Console.WriteLine("Vnesi nekoj string: ");
            string str = Console.ReadLine();
            //Console.WriteLine(@"C:\Program Files\CCleaner");
            Console.WriteLine(str.Length);

            //StartsWith
            Console.WriteLine(str.StartsWith("I"));
            //IndexOf
            Console.WriteLine(str.IndexOf("code"));
            Console.WriteLine(str.IndexOf("code2"));
            Console.WriteLine(str.IndexOf("w"));
            Console.WriteLine(str.IndexOf('w'));
            */
            #endregion

            #region Test strings 3
            /*
            //Substring
            Console.Write("Vnesi nekoj string: ");
            string str = Console.ReadLine();

            Console.WriteLine(str.Substring(2, 3));
            Console.WriteLine(str.Substring(str.Length - 5, 5));

            //Split
            string[] words = str.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");

            //ToCharArray
            char[] chars;
            chars = str.ToCharArray(5,10);
            foreach (var charr in chars)
            {
                Console.Write(charr+"|");
            }
            Console.WriteLine();
            */
            #endregion

            #region DateTime 
            /*
            DateTime dt = DateTime.Now;
            Console.WriteLine("Now {0}", dt);
            Console.WriteLine("Datetime now plus 3 days {0}", dt.AddDays(3));
            Console.WriteLine("Datetime now plus -3 days {0}", dt.AddDays(-3));
            Console.WriteLine("Datetime now plus 1 months and 3.5 days {0}",
                dt.AddMonths(1).AddDays(3.5));

            //Print only the current month with words
            Console.WriteLine(GetMonthName(dt.Month));

            string monthName = new DateTime(dt.Year, dt.Month, dt.Day)
                .ToString("MMM", CultureInfo.InvariantCulture);
            Console.WriteLine(monthName);

            monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dt.Month);
            Console.WriteLine(monthName);

            Console.WriteLine("Birth date: ");
            DateTime bd = Convert.ToDateTime(Console.ReadLine());
            CalcAge(dt, bd);             
            */
            #endregion
        }
        
        #region Funkcii
        //years,months and days
        private static void CalcAge(DateTime dt, DateTime bd)
        {
            //consider dt (now date) is bigger than bd (birth date)
            if (dt >= bd)
            {
                int totalDays = (int)(dt - bd).TotalDays; 
                int yrs = totalDays / 365;
                int mnts = (totalDays - 365 * yrs) / 30; //consider average month length as 30 days
                int days = (totalDays - 365 * yrs - mnts * 30);
                if (dt.DayOfYear >= 59) //Jan 31 + Feb 28 = 59, add one more day
                    days++;
                Console.WriteLine("Your age is approximately {0} years, {1} months and {2} days", yrs, mnts, days);
            }
            else
                Console.WriteLine("Your age is 0 years, 0 months and 0 days");
        }
        static string GetMonthName(int m)
        {
            switch (m)
            {
                case 1:
                    return "January"; 
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "Not a valid month number";
            }
        }                
        static double Suma(double a, double b)
        { 
            return a + b;
        }
        static double Razlika(double x, double y)
        {
            return x - y;
        }
        #endregion
    }
}
