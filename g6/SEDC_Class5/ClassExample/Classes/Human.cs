using System;

namespace ClassExample.Classes
{
    public class Human
    {
        private string SSN;

        public string FirstName;
        public string LastName;
        public string Address;
        public DateTime Birthdate;

        public Human()
        {

        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Human(string firstName)
        {
            FirstName = firstName;
        }

        public void PrintFullName()
        {
            Console.WriteLine($"This person is {FirstName} {LastName}");
        }
    }
}