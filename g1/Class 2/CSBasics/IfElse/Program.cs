using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class Program
    {
        // Programata opredeluva kakov e vneseniot broj preku tastatura.
        static void Main(string[] args)
        {

            string input;
            Console.Write("Vnesi cel broj: ");
            input = Console.ReadLine();
            int broj;
            broj = int.Parse(input);

            if (broj > 0)
                Console.WriteLine("Vensen e pozitiven broj.");
            if (broj < 0)
                Console.WriteLine("Vnesen e negativen broj.");
            if (broj == 0)
                Console.WriteLine("Vnesen e nula.");
            Console.ReadLine();

            //the same code with else-if
            if (broj > 0)
                Console.WriteLine("Vensen e pozitiven broj.");
            else if (broj == 0)
                Console.WriteLine("Vnesen e nula.");
            else 
                Console.WriteLine("Vnesen e negativen broj.");

            int a=0, b=0;
            Console.WriteLine("vnesi dva broja");
            input = Console.ReadLine(); a = int.Parse(input);
            input = Console.ReadLine(); b = int.Parse(input);
            if (a > b) 
                Console.WriteLine("a e pogolemo od b"); 
            else
            { Console.WriteLine("a ne e pogolemo od b"); }
            Console.ReadLine();                
        }
    }
}
