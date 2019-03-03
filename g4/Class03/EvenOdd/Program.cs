using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static (int, bool) ReadIntFromConsole(string message = "")
        {
            if (!String.IsNullOrEmpty(message))
            {
                Console.Write(message);
            }
            var input = Console.ReadLine();
            var parseResult = int.TryParse(input, out int result);
            if (!parseResult)
            {
                return (0, false);
            }
            return (result, true);
        }

        static void Main(string[] args)
        {
            var (first, success) = ReadIntFromConsole("Enter first number: ");
            if (!success)
            {
                Console.WriteLine("Entered value is not a number");
                return;
            }

            int index = 2;
            while (index < first)
            {
                Console.WriteLine($"Counting even {index}");
                Thread.Sleep(50);
                index += 2;
            }

            int second;
            (second, success) = ReadIntFromConsole("Enter second number: ");
            if (!success)
            {
                Console.WriteLine("Entered value is not a number");
                return;
            }

            for (int i = 1; i < second; i+=2)
            {
                Console.WriteLine($"Counting odd {i}");
                Thread.Sleep(50);
            }

        }
    }
}
