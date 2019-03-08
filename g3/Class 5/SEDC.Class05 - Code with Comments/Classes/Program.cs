using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.MyClasses; // this is the namespace of our class Person
// We must include this so we can use our Person class

namespace Classes
{
	class Program
	{
		static void Main(string[] args)
		{
			// Creating an empty person object ( using the parameterless constructor )
			Person bob = new Person();
			bob.Name = "Bob Bobsky";
			bob.Age = 34;
			//bob.SSN = 3453254252; // We can't access this. It's private
			bob.Talk("Hey there");
			//bob.GenerateSSN(); // We can't call this. It's private
			
			// Creating an empty person object and immediately giving it values to the properties
			Person bill = new Person() { Name = "Bill Wurtz", Age = 31 };
			bill.Talk("Good day people");

			// Creating a person object using the second construvtor with parameters
			Person jill = new Person("Jill Wayne", 29); // we don't need to set the properties
			jill.Talk("Hello!");

			// Creating a product because we have access to it since we are in the same namespace
			Product car = new Product() { Name = "Car", Code = 12314, Price = 6500.99 };
			car.Buy(5000);
			car.Buy(10000);

			// Creating an annonimous object
			// We cant add methods in these objects, just properties
			var annonObject = new
			{
				Name = "Random Object",
				Quantity = 25
			};
			Console.WriteLine(annonObject.Name);
			Console.ReadLine();
		}
	}
}
