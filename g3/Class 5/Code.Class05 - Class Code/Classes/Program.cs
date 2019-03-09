using Classes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
			static void AgeCalculator(DateTime birthdate)
		{
			DateTime currentTime = DateTime.Now;
			int age = currentTime.Year - birthdate.Year;
			if (birthdate.Month > currentTime.Month) age--;
			if (birthdate.Month == currentTime.Month && birthdate.Day > currentTime.Day) age--;
			Console.WriteLine($"Your age is: {age}");
			Console.ReadLine();
		}
    // KLASI
    class Person
    {
        // Properties
//    <acc.mod><type><name><getterAndSetter>
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; } = new Address();
        public Job Job { get; set; } = new Job();
        private long SSN { get; set; }
        // Constructor
        public Person()
        {
            Console.WriteLine("Constructing person...");
            Address = new Address();
            SSN = GenerateSSN();
            Name = "Petko";
            Age = 25;
        }

        public Person(string name, int age)
        {
            Console.WriteLine("The other constructor is constructing a Person...");
            Address = new Address();
            SSN = GenerateSSN();
            Name = name;
            Age = age;
        }
        private long GenerateSSN()
        {
            return new Random().Next(1000000, 9999999);
        }
        // Methods
        public void PrintPerson()
        {
            Console.WriteLine($"Name:{Name}, Age:{Age}, SSN:{SSN}");
        }
    }
    class Program
    {
        // METODI
        static void Main(string[] args)
        {
            // KOD
            //Person dejan = new Person();
            //dejan.Name = "Dejan";
            //dejan.Age = 19;
            ////dejan.Address = new Address();
            //dejan.Address.Name = "Narodni Heroi";
            //dejan.Address.Number = 24;
            //dejan.PrintPerson();
            //Person dragan = new Person()
            //{
            //    Name = "Dragan",
            //    Age = 55
            //};
            //dragan.PrintPerson();
            //Person randomPerson = new Person();
            //randomPerson.PrintPerson();
            //Person bob = new Person("Bob", 67);
            //bob.PrintPerson();
            //Console.WriteLine(bob.GetType());
            var annonObject1 = new
            {
                Name = "RandomName1",
                Number = "RandomNumber1"
            };
            object annonObject2 = new
            {
                Name = "RandomName2",
                Number = "RandomNumber2"
            };
            Console.WriteLine(annonObject1.Name);

            Console.ReadLine();
			#region Age Calculator
			Console.WriteLine("Enter your birthdate in format: month-day-year");
			DateTime birthday = DateTime.Parse(Console.ReadLine());
			AgeCalculator(birthday);
			#endregion
        }
    }
}
