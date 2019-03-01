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
            //Console.WriteLine("Implicit conversion");
            ////1. the compiler implicitly converts x from int to double
            //double b = 12.45;
            //int a = 10;
            //b = b + a;
            ////2. when the compiler stores the result to a variable
            //int x = 21;
            //int y = 5;
            //double z = x / y;
            //Console.WriteLine($"z={z}");
            //Console.ReadLine();

            //Console.WriteLine("Explicit conversion");
            //int c;
            //int x = 21;
            //int y = 5;
            //double d = 10.7;
            //c = (int)d;
            //Console.WriteLine($"c={ c}");
            //double z = (double)x / y;
            //Console.WriteLine($"z={z}");
            //string cs = Convert.ToString(c);
            //string cz = z.ToString();
            //Console.WriteLine($"cs={cs}");
            //Console.WriteLine($"cz={cz}");
            //Console.ReadLine();

            //Console.WriteLine("Special caracters");
            //Console.WriteLine("\\-\t-\b");
            //Console.ReadLine();

            //Console.WriteLine("While");
            //int i = 0;
            //while(i<10)
            //{
            //    Console.WriteLine($"Iteracija {i}");
            //    i++;
            //}
            //Console.ReadLine();

            //Console.WriteLine("Do While");
            //int j = 0;
            //do
            //{
            //    Console.WriteLine($"Iteracija {j}");
            //    j++;
            //} while (j < 10);
            //Console.ReadLine();

            //Console.WriteLine("For");
            //for (int k = 0; k < 10; k++)
            //{
            //    Console.WriteLine($"Iteracija {k}");
            //}
            //Console.ReadLine();

            //Console.WriteLine("Break/Continue/Infinite loop");
            //int l = 0;
            //while (l < 10)
            //{
            //    if (l == 5)
            //    {
            //        l++;
            //        continue;
            //    }
            //    Console.WriteLine($"Iteracija {l}");
            //    l++;
            //}
            //Console.ReadLine();

            //Console.WriteLine("Arrays");
            //string[] movies = { "Movie1", "Movie2", "Movie3", "Movie4" };
            //Console.WriteLine("Movies:");
            //foreach (string movie in movies)
            //{
            //    Console.Write($"{movie} ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine($"Index of Movie3 = {Array.IndexOf(movies, "Movie3")}");
            //Console.ReadLine();

            int[] numbers = new int[5];
            for (int n = 0; n < 5; n++)
            {
                Console.Write($"number{n} = ");
                numbers[n] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine("Numbers:");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            //Console.ReadLine();

            //Console.WriteLine($"numbers.Length = {numbers.Length}");
            //Console.ReadLine();

            //Console.WriteLine("Sorted numbers:");
            //Array.Sort(numbers);
            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //Console.WriteLine("Reversed numbers:");
            //Array.Reverse(numbers);
            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} ");
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            Console.WriteLine("Resized numbers:");
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = 89;
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.ReadLine();




            // This is for the aplication to be active until some condition is meet;
            //bool isOk = true;
            //while (isOk)
            //{
            //    ... More code here
            //    int a = int.Parse(Console.ReadLine());
            //    if(a == 10)
            //    {
            //        isOk = false;
            //    }
            //}


            //Console.ReadLine();

        }
    }
}
