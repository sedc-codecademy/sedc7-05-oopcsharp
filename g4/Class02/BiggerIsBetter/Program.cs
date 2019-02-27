using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerIsBetter
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

            int bigger = (first > second) ? first : second;
            bool isEven = bigger % 2 == 0;
            string oddEven = isEven ? "even" : "odd";

            Console.WriteLine($"Between {first} and {second} the bigger one is {bigger}, which is an {oddEven} number");
        }
    }
}
