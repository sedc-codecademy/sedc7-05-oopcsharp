using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //double to int
            Console.WriteLine("Conversion double 9.81 to interger");
            double d = 9.81;
            int i;
            i = (int)d;
            Console.WriteLine(i);
            Console.ReadKey();

            //float to int
            Console.WriteLine("Conversion float 2.729F to interger");
            float f = 2.729f;
            int i2;
            i2 = (int)f;
            Console.WriteLine(i2);
            Console.ReadKey();

            //anything to string
            Console.WriteLine("Conversion: (88, 67.0005f, 234234.55, true) to string ");
            int i3 = 88;
            float f2 = 67.0005f;
            double dc = 234234.55;
            bool b = true;

            Console.WriteLine(i3.ToString());
            Console.WriteLine(f2.ToString());
            Console.WriteLine(dc.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine("Anything is convertable to string");
            Console.ReadKey();

            double decimalen = 1;
            Console.WriteLine("1 is a decimal number in this case {0} with type", decimalen.GetType().ToString());
            Console.ReadKey();
            
            //Using "var" for declaration of variables
            var x = 100;
            Console.WriteLine("The data type of var x = 100 is {0}", x.GetType().ToString());
            Console.ReadKey();

            var pi = 3.14159;
            Console.WriteLine("The data type of var pi = 3.14159 is {0}", pi.GetType().ToString());
            Console.ReadKey();

            var g = 9.81m;
            Console.WriteLine("The data type of var g = 9.81m; is {0}", g.GetType().ToString());
            Console.ReadKey();
        }
    }
}
