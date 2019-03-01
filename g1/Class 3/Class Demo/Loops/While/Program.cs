using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj, i, rez;
            Console.WriteLine("Vnesi cel broj");
            broj = Convert.ToInt32(Console.ReadLine());
            //broj = Int32.Parse(Console.ReadLine());
            //Int32.TryParse(Console.ReadLine(), out broj);

            Console.WriteLine("Demonstration of while loop ...");
            i = 1;
            while (i<=10)
            {
                rez = broj * i;
                Console.WriteLine("{0} x {1} = {2}", broj, i, rez);
                i++;
            }
            Console.ReadLine();

            Console.WriteLine("Demonstration of do-while loop ...");
            i = 1;
            do
            {
                rez = broj * i;
                Console.WriteLine("{0} x {1} = {2}", broj, i, rez);
                i++;
            } while (i <= 10);
            Console.ReadLine();

        }
    }
}
