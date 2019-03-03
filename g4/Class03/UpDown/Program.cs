using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UpDown
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

            for (int i = 0; i < first; i += 1)
            {
                Console.WriteLine($"Counting up: {i + 1}");
                Thread.Sleep(100);
            }

            int second;
            (second, success) = ReadIntFromConsole("Enter second number: ");
            if (!success)
            {
                Console.WriteLine("Entered value is not a number");
                return;
            }

            var index = second;
            while (index > 0)
            {
                Console.WriteLine($"Counting down: {index}");
                Thread.Sleep(100);
                index -= 1;
            };
        }
    }
}
