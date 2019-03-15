using System;

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
    }
}
