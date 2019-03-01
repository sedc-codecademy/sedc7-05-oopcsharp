using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise5
            int[] array1 = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"number{i} = ");
                array1[i] = int.Parse(Console.ReadLine());
                sum += array1[i];
            }
            Console.WriteLine($"Sum = {sum}");
            Console.ReadLine();
        }
    }
}
