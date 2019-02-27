using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
         /*
            Demonstracija na aritmetickite operatori.
         */
        static void Main(string[] args)
        {
            int a, b;
            a = 20; b = 10;

            Console.WriteLine("a = {0}, b = {1} ", a, b);
            //Console.WriteLine($"a = {a}, b = {b} ");
            int suma = a + b;
            Console.WriteLine("a + b = {0}", suma);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a % b = {0}", a % b);

            Console.WriteLine("-------------");
            Console.WriteLine("a++ and b--");
            Console.WriteLine("a = {0}", a++);
            Console.WriteLine("b = {0}", b--);

            Console.WriteLine("++a and --b");
            Console.WriteLine("a = {0}", ++a);
            Console.WriteLine("b = {0}", --b);             
            Console.ReadLine();            
        }
    }
}
