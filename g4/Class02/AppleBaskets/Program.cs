using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBaskets
{
    class Program
    {
        const int applesPerBranch = 12;

        static void Main(string[] args)
        {
            Console.Write("Enter number of branches: ");
            var numBranchesInput = Console.ReadLine();
            bool parseResult = int.TryParse(numBranchesInput, out int numBranches);

            if (!parseResult)
            {
                Console.WriteLine($"You entered '{numBranchesInput}' which is not a valid integer");
                return;
            }

            Console.Write("Enter basket capacity: ");
            var capacityInput = Console.ReadLine();
            parseResult = int.TryParse(capacityInput, out int capacity);

            if (!parseResult)
            {
                Console.WriteLine($"You entered '{capacityInput}' which is not a valid integer");
                return;
            }

            int numApples = applesPerBranch * numBranches;

            int numBaskets = numApples / capacity;

            if (numApples % capacity != 0)
            {
                numBaskets += 1;
            }

            Console.WriteLine("---------------");

            Console.WriteLine($"You need a total of {numBaskets} baskets to transport {numApples} apples");
        }
    }
}
