using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedcSimulator
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public Person(string firstName, string lastName)
        {
            Console.WriteLine("In Person constructor");

            FirstName = firstName;
            LastName = lastName;
        }

    }
}
