using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise3
            Console.Write("number1 = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numbers from 1 to {number1}:");
            int i = 1;
            while (i <= number1)
            {
                if (i == 100)
                {
                    Console.WriteLine("The limit is reached");
                    break;
                }
                else
                {
                    if (i % 3 == 0 || i % 7 ==0)
                    {
                        i++;
                        continue;
                    }
                }
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
