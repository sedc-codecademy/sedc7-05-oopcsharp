using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Horizontal tab ( \t ) so 2 novi reda ( \n )
            Console.WriteLine("Hello\tWorld\n\n");

            //horizontal tab ( \t ) + carrige return ( \r )
            Console.WriteLine("Hi the\tre\t\r");

            // \ - backslash ( \\ )
            Console.WriteLine("Cel na doznaka: 2345-34\\1 " +"\n");
            
            // \a - Alert or Bell
            Console.WriteLine("\a");
            Console.ReadLine();
        }
    }
}
