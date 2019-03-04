using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(Add(3, 4));
        }

        static int Add(int first, int second)
        {
            return first + second;
        }

        static void Print(int x)
        {
            Console.WriteLine($"The value is {x}");
        }
    }
}
