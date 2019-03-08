using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------NOW-------------");

            var now = DateTime.Now;
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());

            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            Console.WriteLine("---------TODAY------------");

            var today = DateTime.Today;
            Console.WriteLine(today.ToShortTimeString());
            Console.WriteLine(today.ToLongTimeString());
            Console.WriteLine(today.ToShortDateString());
            Console.WriteLine(today.ToLongDateString());

            Console.WriteLine(today.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            Console.WriteLine("---------CREATE------------");

            var independenceDayMk = new DateTime(1991, 9, 8);
            Console.WriteLine(independenceDayMk.ToShortTimeString());
            Console.WriteLine(independenceDayMk.ToLongTimeString());
            Console.WriteLine(independenceDayMk.ToShortDateString());
            Console.WriteLine(independenceDayMk.ToLongDateString());

            Console.WriteLine(independenceDayMk.ToString("yyyy-MM-dd HH:mm:ss.fff"));

            Console.WriteLine("---------Play around------------");

            Console.WriteLine(independenceDayMk.AddDays(-1).AddYears(1));

            Console.WriteLine(today.AddDays(45));

            Console.WriteLine(DateTime.Today - independenceDayMk);
            Console.WriteLine(independenceDayMk.AddDays(10039));

            var birthday = new DateTime(1977, 7, 16);
            var age = AgeCalculator(birthday);
            Console.WriteLine($"A person born on {birthday} is {age} years old");

            var b2 = new DateTime(1977, 1, 1);
            Console.WriteLine($"A person born on {b2} is {AgeCalculator(b2)} years old");

            var b3 = new DateTime(1977, 3, 4);
            Console.WriteLine($"A person born on {b3} is {AgeCalculator(b3)} years old");

        }

        static int AgeCalculator(DateTime birthday)
        {
            var thisYearBday = new DateTime(DateTime.Today.Year, birthday.Month, birthday.Day);
            var result = DateTime.Today.Year - birthday.Year;
            if (thisYearBday > DateTime.Today)
            {
                result -= 1;
            }
            return result;
        }


    }
}
