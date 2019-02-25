using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            var firstInput = Console.ReadLine();
            bool firstResult = int.TryParse(firstInput, out int first);

            if (!firstResult)
            {
                Console.WriteLine($"You entered '{firstInput}' which is not a valid integer");
                return;
            }

            Console.Write("Enter second number: ");
            var secondInput = Console.ReadLine();
            bool secondResult = int.TryParse(secondInput, out int second);

            if (!secondResult)
            {
                Console.WriteLine($"You entered '{secondInput}' which is not a valid integer");
                return;
            }

            Console.WriteLine("---------------");
            Console.WriteLine(first + second);
        }
    }
}
