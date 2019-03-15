using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human(string name, int age)
        {
            Console.WriteLine("Human Constructor with properties");
            Name = name;
            Age = age;
        }

        public Human()
        {
            Console.WriteLine("Human Default constructor called");
        }

        public virtual string PrintInfo()
        {
            return $"Hi I'm {Name} and I'm {Age} years old";
        }
    }
}
