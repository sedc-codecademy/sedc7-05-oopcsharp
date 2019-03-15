using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    // Animal class, a parent class from which other classes will inherit
    public class Animal
    {
        // These properties will be shared with all classes that inherit from this one
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        // Eet method that all classes that inherit from this one can call
        // We write virtual if we want this method to be overriden by child classes
        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal named {Name} is eating!");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Animal: {Type}, Name: {Name}");
        }

        // Default constructor of animal. It will be called when new instance of Animal is created
        // It will also be called when new instance of any other child class is created
        // The parent constructor always executes first
        public Animal()
        {
            Console.WriteLine("A new instance of an animal has been created. This is the Animal constructor.");
        }

        // Another constructor that takes a string as parameter
        public Animal(string type)
        {
            Type = type;
            Console.WriteLine("This is an ID constructor of Animal.");
        }
    }
}
