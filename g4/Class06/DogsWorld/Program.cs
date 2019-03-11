using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var lola = new Dog("Lola");
            lola.Breed = "Bichon Frise";
            lola.Color = "White";
            Console.WriteLine(lola);
            Console.WriteLine("------");

            Console.WriteLine(lola.Eat("dog food"));
            Console.WriteLine(lola.Play("ball"));
            Console.WriteLine(lola.ChaseTail());

            Console.WriteLine(lola.Eat());
            Console.WriteLine(lola.Play());

        }
    }
}
