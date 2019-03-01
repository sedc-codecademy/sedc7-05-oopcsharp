using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //double value = 10.46;
            //Console.WriteLine("{0} --> {1} (rounded)", value, Math.Round(value,1));
            //System.Console.ReadLine();

            //int a = 5, b = 7;
            //System.Console.WriteLine("a={0}, b={1}",a,b);
            //System.Console.WriteLine("a++={0}, b++={1}", a++, b++);
            //System.Console.WriteLine("After a++={0}, b++={1}", a, b);

            //decimal a = 7m;
            //int b = 3;
            //System.Console.WriteLine(a/b);
            

            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated

            //Console.WriteLine("Vnesete broj");
            //string x = Console.ReadLine();
            ////int a = int.Parse(x);
            ////int a = Convert.ToInt32(x);
            //int a = 0;
            //int.TryParse(x, out a);
            //System.Console.WriteLine($"a={a}");

            //Console.WriteLine("Vnesete broj");
            //string numStr = Console.ReadLine();
            //int num = 0;
            //bool isConverted;
            //isConverted = int.TryParse(numStr, out num);
            //Console.WriteLine($"isConverted={isConverted}, num={num}");

            //int a = 5;
            //double b = 3;
            //Console.WriteLine(a / b);

            int b = Convert.ToInt32(null);
            System.Console.WriteLine($"b={b}");

            int c;
            int.TryParse(null, out c);
            System.Console.WriteLine($"c={c}");

            System.Console.ReadLine();
        }
    }
}
