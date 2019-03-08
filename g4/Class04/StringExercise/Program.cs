using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // your code here
            Substrings(10);
        }

        static void Substrings(int n)
        {
            var source = "Hello from SEDC CodeCademy v7.0";
            Console.WriteLine(source.Substring(6));
            Console.WriteLine(source.Substring(0, 5));

            // your code here (using Console.WriteLine)
            // "The first XXX characters are YYY"
            // "Substring: YYY, length: XXX"
        }

        static void SplitAt(string input, int splitIndex)
        {
            // HOMEWORK:
            // your code here;
            // "Hello from SEDC CodeCademy v7.0", 5
            // "Hello " and "from SEDC CodeCademy v7.0"
        }
    }
}
