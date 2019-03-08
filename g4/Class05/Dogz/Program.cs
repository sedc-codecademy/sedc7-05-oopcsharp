using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogz
{
    class Program
    {
        static void Main(string[] args)
        {
            var lola = new Dog();
            lola.Name = "Lola";
            lola.Race = "Bichon Frise";
            lola.Color = "White";

            while (true)
            {
                Console.Clear();
                Console.WriteLine(lola);
                Console.WriteLine("Enter Command");
                Console.WriteLine("1 to play");
                Console.WriteLine("2 to eat");
                Console.WriteLine("3 to chase its tail");
                Console.WriteLine("9 to exit");

                int.TryParse(Console.ReadLine(), out int command);

                if (command == 9)
                {
                    return;
                }
                if (command == 1)
                {
                    Console.WriteLine(lola.Play());
                }
                else if (command == 2)
                {
                    Console.WriteLine(lola.Eat("dog food"));
                }
                else if (command == 3)
                {
                    Console.WriteLine(lola.ChaseTail());
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
                var hungryDog = lola.IsHungry ? "" : "not ";
                Console.WriteLine($"{lola.Name} is now {hungryDog}hungry");

                // lola.IsHungry = false;

                Console.ReadLine();
            }
        }
    }
}
