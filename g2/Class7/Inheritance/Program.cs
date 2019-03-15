
using MyFirstLibrary.Enums;
using MyFirstLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer jonce = new Programmer(Title.Junior, "C#", 1, "Jonce", 24);

            Console.WriteLine(jonce);

            Console.ReadLine();
        }
    }
}
