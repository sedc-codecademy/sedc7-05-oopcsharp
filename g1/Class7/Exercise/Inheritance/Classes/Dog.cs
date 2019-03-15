using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    // A Dog class that inherits from Animal
    public class Dog : Animal
    {
        // A property unique to Dog class. It also has all Animal properties ( Id, Name, Type )
        public string Race { get; set; }

        // A method unique to Dog
        public void Bark()
        {
            Console.WriteLine("Bark, Bark!");
        }

        // Constructor of Dog that will be called on every new instance
        // This Animal default constructor is first called, then this one
        public Dog()
        {
            Console.WriteLine("A new instance of a Dog is created and also called the default Parent constructor.");
        }
    }
}
