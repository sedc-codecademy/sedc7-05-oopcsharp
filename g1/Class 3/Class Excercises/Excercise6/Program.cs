using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            int i = 0;
            do
            {
                Array.Resize(ref names, names.Length + 1);

                Console.Write("Name = ");
                names[i] = Console.ReadLine();

                Console.WriteLine($"Names{i}:");
                foreach (string name in names)
                {
                    Console.Write($"{name} ");
                }
                Console.WriteLine();
                i++;

                Console.WriteLine("Another name? (Y/N)");
            } while (Console.ReadLine().ToUpper() != "N");

            Console.ReadLine();
        }
    }
}
