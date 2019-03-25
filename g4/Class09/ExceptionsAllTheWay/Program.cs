using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAllTheWay
{
    class Program
    {
        static bool Chance()
        {
            return new Random().NextDouble() > 0.5;
        }

        static void Main(string[] args)
        {
            try
            {
                // potentially won't work and will throw an exception
                int zero = Chance() ? 0 : 1;
                int result = 7 / zero;

                //int[] array = { 1, 2, 3, 4 };
                //Console.WriteLine(array[10]);

                // second exception
                int pet = int.Parse("pet");

                Console.WriteLine("Result");
                return;
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Format Exception occured");
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                // log the exception, and if possible handle it
                Console.WriteLine("Exception occured");
                Console.WriteLine(exception.Message);
            }
            Console.WriteLine("End-of-program");
        }
    }
}
