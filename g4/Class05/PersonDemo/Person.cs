using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDemo
{
    public class Person
    {
        // direct field access
        //public string FirstName;

        //public string LastName;

        // getter and setter separate methods (ala Java)
        //private string firstName;

        //public string GetFirstName()
        //{

        //    return firstName;
        //}

        //public void SetFirstName(string value)
        //{
        //    //if (string.IsNullOrEmpty(value))
        //    //{
        //    //    return;
        //    //}
        //    firstName = value;
        //}

        //private string lastName;

        //public string GetLastName()
        //{
        //    return lastName;
        //}

        //public void SetLastName(string value)
        //{
        //    lastName = value;
        //}

        // real auto properties
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        public Person(string firstName)
        {
            FirstName = firstName;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person() { }

        // real properties
        public string LastName { get; set; }

        private string firstName;
        public string FirstName {
            get
            {
                // Console.WriteLine("called firstname getter");
                return firstName;
            }
            set
            {
                // Console.WriteLine("called firstname setter");
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                firstName = value;
            }
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
