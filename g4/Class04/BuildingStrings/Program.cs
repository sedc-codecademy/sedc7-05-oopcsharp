using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;
            string longish = MakeLongString2(20000000);
            DateTime end = DateTime.Now;
            Console.WriteLine((end - start).TotalMilliseconds);
        }

        static string MakeLongString(int length)
        {
            string result = "A";

            for (int i = 0; i < length; i++)
            {
                result += "A";
            }
            return result;
        }

        static string MakeLongString2(int length)
        {
            StringBuilder result = new StringBuilder("A");

            for (int i = 0; i < length; i++)
            {
                result.Append("A");
            }
            return result.ToString();
        }
    }
}
