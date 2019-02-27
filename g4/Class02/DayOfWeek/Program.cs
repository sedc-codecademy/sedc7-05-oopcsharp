using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter day number: ");
            var dayInput = Console.ReadLine();
            bool parseResult = int.TryParse(dayInput, out int dayValue);

            if (!parseResult)
            {
                Console.WriteLine($"You entered '{dayInput}' which is not a valid integer");
                return;
            }

            switch (dayValue)
            {
                case 1:
                    Console.WriteLine("Today is Monday");
                    break;
                case 2:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Odin's Day");
                    break;
                case 4:
                    Console.WriteLine("Today is Thor's Day");
                    break;
                case 5:
                    Console.WriteLine("Today is Freya's Day");
                    break;
                case 6:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 7:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine($"Unknown day index {dayValue}");
                    break;
            }

        }
    }
}
