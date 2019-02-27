using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    class Program
    {        
        static void Main(string[] args)
        {
            bool a = true, b = false;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("Logical AND between a and b: {0}", a && b);
            Console.WriteLine("a OR b: {0}", a || b);
            Console.WriteLine("NOT(a): {0}", !a);
            Console.WriteLine("NOT(b): {0}", !b);
            Console.WriteLine("NOT(a AND b): {0}", !(a && b));
                        
            Console.ReadLine();            
        }
    }
}
