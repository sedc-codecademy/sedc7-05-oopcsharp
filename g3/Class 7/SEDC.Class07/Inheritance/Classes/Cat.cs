using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    // A Cat class that inherits from Animal class
    public class Cat : Animal
    {
        // Propertie unique to Cat. Cat also has all properties from Animal ( Id, Name, Type )
        public string Lazyness { get; set; }

        // A method Eat which was overriden by the class cat with the keyword override
        // This method will now execute instead of the Eat() method in Animal class
        public override void Eat()
        {
            Console.WriteLine("You don't tell a cat when to eat. A CAT EATS WHEN IT WANTS!");
        }

        // Unique method for Cat class only
        public void Meow()
        {
            Console.WriteLine("Meow Meow");
        }

        // Constructor of cat that selects which constructor it will call first from parent with the base () 
        // This will call the constructor that takes a string from Animal, and then the Cat() constructor
        // This will not execute the default constructor in Animal
        public Cat() : base("Cat")
        {
            Console.WriteLine("A new instance of cat is created by the parent constructor that requires a stirng!");
        }
    }
}
