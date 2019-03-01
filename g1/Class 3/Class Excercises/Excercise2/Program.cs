using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise2
            Console.Write("number1 = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Even numbers from 2 to {number1}:");
            int i = 2;
            while (i <= number1)
            {
                Console.Write($"{i} ");
                i = i + 2;
            }
            Console.WriteLine();
            Console.ReadLine();

            Console.Write("number2 = ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Odd numbers from 1 to {number2}:");
            int j = 1;
            while (j <= number2)
            {
                Console.Write($"{j} ");
                j = j + 2;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
