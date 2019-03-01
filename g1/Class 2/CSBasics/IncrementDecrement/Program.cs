using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            //incrementing
            Console.WriteLine("Incrementing...");
            int x = 5;
            Console.WriteLine("x++ = {0}", x++);
            Console.WriteLine("x now: {0}",x);
            int y = 5;
            Console.WriteLine("++y = {0}", ++y);
            Console.ReadLine();

            //decrementing
            Console.WriteLine("Decrementing...");
            x = 5;y = 5;
            Console.WriteLine("x-- = {0}", x--);
            Console.WriteLine("x now: {0}", x); 
            Console.WriteLine("--y = {0}", --y);
            Console.ReadLine();
        }
    }
}
