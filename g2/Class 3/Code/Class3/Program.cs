using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {

            //int number;
            //do
            //{
            //    Console.Write("Please enter a number: ");
            //    string input = Console.ReadLine();
            //    number = int.Parse(input);
            //    Console.WriteLine(number);
            //    if (number > 0)
            //    {
            //        for (i = 0; i < number; i++)
            //        {
            //            Console.WriteLine(i + 1);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number must be positive! :)");
            //    }
            //} while (number < 0);

            Console.WriteLine("Enter a number bigger than one (1)");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number.GetType());
            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                } else if (i == 100)
                {
                    Console.WriteLine("You have reached the limit");
                    break;
                } else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
