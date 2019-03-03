using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise1
            Console.Write("number1 = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numbers from 1 to {number1}:");
            int i = 1;
            while (i <= number1)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine();
            Console.ReadLine();

            Console.Write("number2 = ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numbers from {number2} to 1:");
            int j = number2;
            while (j >= 1)
            {
                Console.Write($"{j} ");
                j--;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
