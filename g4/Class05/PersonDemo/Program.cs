using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var weko = new Person();
            //var wekoStr = weko.ToString();
            //Console.WriteLine(wekoStr);

            //var viktor = new Person();
            //Console.WriteLine(viktor);

            //Console.WriteLine("--------");
            // With direct field access
            //weko.FirstName = "Wekoslav";
            //weko.LastName = "Stefanovski";
            //Console.WriteLine($"{weko.FirstName} {weko.LastName}");

            //weko.FirstName = "Vlatko";
            //Console.WriteLine($"{weko.FirstName} {weko.LastName}");

            //weko.FirstName = null;
            //Console.WriteLine($"{weko.FirstName} {weko.LastName}");

            // with unrestricted getter and setter
            //weko.SetFirstName("Wekoslav");
            //weko.SetLastName("Stefanovski");
            //Console.WriteLine($"{weko.GetFirstName()} {weko.GetLastName()}");

            //weko.SetFirstName("Vlatko");
            //Console.WriteLine($"{weko.GetFirstName()} {weko.GetLastName()}");

            //weko.SetFirstName(null);
            //Console.WriteLine($"{weko.GetFirstName()} {weko.GetLastName()}");

            // With property access
            var weko = new Person("Wekoslav", "Stefanovski");
            var wekoStr = weko.ToString();
            Console.WriteLine(wekoStr);

            var viktor = new Person("Viktor");
            Console.WriteLine(viktor);

            weko.FirstName = "Wekoslav";
            weko.LastName = "Stefanovski";
            Console.WriteLine(weko.GetFullName());

            weko.FirstName = "Vlatko";
            Console.WriteLine(weko.GetFullName());

            weko.FirstName = null;
            Console.WriteLine(weko.GetFullName());
        }
    }
}
