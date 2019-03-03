using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration {0}", i);
            }
            
            Console.WriteLine("\nPress a key\n");
            Console.ReadKey();

            for (int j = 0; j < 10; j++)
            {
                Console.Write("{0} ", j);
            }
            Console.WriteLine("\nPress a key\n");
            Console.ReadKey();

            for (i = 0; i < 5; i--)
            {
                Console.WriteLine("Iteration {0}, find out the problem", i);
                if (Math.Abs(i) > 10000)
                    break; //break stops the loop
            }
            Console.ReadLine();
        }
    }
}
