using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.MyClasses // this is the address of this class
{
	public class Person
	{
		// Properties must have type, acces modifier and get/set
		public string Name { get; set; }
		public int Age { get; set; }
		private long SSN { get; set; }  // Private method that can only be accessed in this class
		// Constructors
		public Person() // an empty constructor that generates a Social Security Number
		{
			SSN = GenerateSSN();
		}
		public Person(string name, int age) // Constructor that adds values to properties through parameters
		{
			Name = name;
			Age = age;
			SSN = GenerateSSN();
		}
		private long GenerateSSN() // Private method that can only be accessed in this class
		{ 
			return new Random().Next(100000, 999999); // gets a random number between the values
		}
		// Public method that can be accessed anywhere
		public void Talk(string text){
			Console.WriteLine($"The human named {Name}(SSN:{SSN}) is saying: {text}.");
			Console.ReadLine();
		} 
	}
}
