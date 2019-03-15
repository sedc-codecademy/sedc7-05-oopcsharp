using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame.Models
{
    class PlayerTest
    {
        public PlayerTest()
        {
            Console.WriteLine("Default Constructor");
        }
    
        public PlayerTest(string firstName, string lastName):this()
        {
            Console.WriteLine($"Constructor with FirstName={firstName} and LastName={lastName}");
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        private string firstName;
        public string FirstName
        {
            private get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        ~PlayerTest()
        {
            Console.WriteLine("Destructor");
            Console.ReadLine();
        }
    }
}
