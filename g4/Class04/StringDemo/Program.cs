using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Wekoslav";

            Console.WriteLine(name);

            Console.WriteLine(name.ToLower());

            Console.WriteLine(name.ToUpper());

            Console.WriteLine("-------------");

            string lastName = "Stefanovski";
            int age = 0x29;
            Console.WriteLine(name);
            Console.WriteLine(lastName);

            //string fullName = name + " " + lastName +" (" + age + ")";
            //string fullName = $"{name} {lastName} ({age})";
            string format = "{1}, {0} ({2})";

            string fullName = String.Format(format, name, lastName, age);

            Console.WriteLine(fullName);

            int value = 12345;
            Console.WriteLine("{0:##0:000}", value);
            Console.WriteLine("{0:e}", value);

            int x = 1, y = 1000, z = 1000000;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}
