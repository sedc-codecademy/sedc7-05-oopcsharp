using Inheritance.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of all animals to see what constructors will be called and that
            // All animals have access to methods from Animal
            Animal dambo = new Animal() { Name = "Dambo", Id = 5, Type = "Elephant" };
            dambo.PrintInfo();
            dambo.Eat();
            Console.WriteLine("----------------------------------------------------------");
            Dog spark = new Dog() { Name = "Spark", Id = 2, Type = "Dog", Race = "Labrador" };
            spark.PrintInfo();
            spark.Eat();
            spark.Bark();
            Console.WriteLine("----------------------------------------------------------");
            Cat garfield = new Cat() { Name = "Garfield", Id = 3, Lazyness = "Very" }; // We don't tell the type here because the constructor will set it
            garfield.PrintInfo();
            garfield.Eat();
            garfield.Meow();
            Console.ReadLine();
        }
    }
}
