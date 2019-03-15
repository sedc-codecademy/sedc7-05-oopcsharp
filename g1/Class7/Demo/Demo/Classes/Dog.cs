using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Dog:Animal
    {

        public Dog():base("Sarko")
        {
            Console.WriteLine("Dog constructor");
        }
        
        public string PropertyDog { get; set; }
        public void Bark()
        {
            Console.WriteLine("Dog Bark");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Dog Eat");
        }

        ~Dog()
        {
            Console.WriteLine("Dog destructor");
            Console.ReadLine();
        }
    }
}
