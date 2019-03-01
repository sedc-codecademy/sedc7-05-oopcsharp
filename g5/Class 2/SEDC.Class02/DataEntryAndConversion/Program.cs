using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntryAndConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Data Entry
			Console.Write("Write your name: ");
			string name = Console.ReadLine(); // ReadLine waits for a user input and adds that value in to the variable
			Console.WriteLine("Hello there " + name);
			Console.Write("Write a number: ");
			var number = Console.ReadLine();
			Console.WriteLine(number.GetType()); // We get the type with the method GetType()
			Console.ReadLine();
			#endregion
			#region Conversion
			string numberString = "2";
			string doubleString = "2.5";
			// converting with Parse
			int parseInt = int.Parse(numberString);
			double parseDouble = double.Parse(doubleString);
			// converting with Convert				
			int convertInt = Convert.ToInt32(numberString);
			double convertDouble = Convert.ToDouble(doubleString);
			// tryParse example
			int ifParsedValue; // if try parse succseeds we will put the converted value here
							   // We create a boolean variable that will keep info if the parsing was done or not
			bool parsingSuccsess = int.TryParse(numberString, out ifParsedValue);
			Console.WriteLine(parsingSuccsess);
			// Getting a value from a user and parsing it
			Console.Write("Write a number: ");
			var userNumber = int.Parse(Console.ReadLine());
			Console.WriteLine(userNumber.GetType());
			Console.ReadLine();
			#endregion
		}
	}
}
