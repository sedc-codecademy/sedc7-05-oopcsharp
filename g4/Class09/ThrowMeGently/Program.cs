using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowMeGently
{
    class Program
    {
        static bool Chance()
        {
            return new Random().NextDouble() > 0.5;
        }

        static void Main(string[] args)
        {

            //int x = Convert.ToInt32("pet");
            //Console.WriteLine(x);

            //int y = int.Parse("pet");
            //Console.WriteLine(y);
            try
            {
                // potentially won't work and will throw an exception
                Console.WriteLine("Connect to database");
                int zero = Chance() ? 0 : 1;
                int result = 7 / zero;

                int[] array = { 1, 2, 3, 4 };
                Console.WriteLine(array[10]);

                // second exception
                int pet = int.Parse("pet");

                Console.WriteLine("Result");
                return;
            }
            catch (DivideByZeroException exception)
            {
                // log the exception, and if possible handle it
                Console.WriteLine("Divide by Zero Exception occured");
                Console.WriteLine(exception.Message);
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Format Exception occured");
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Disconnect from database");
            }
            Console.WriteLine("End-of-program");
        }
    }
}
