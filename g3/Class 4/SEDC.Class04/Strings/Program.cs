using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
	class Program
	{
		static bool SubstringsExercise()
		{
			string a = "Hello from SEDC Codecademy v6.0";
			Console.WriteLine("Please enter a number");
			int result;

			string b = "";
			if (Int32.TryParse(Console.ReadLine(), out result) != true)
			{
				Console.WriteLine("You have entered an incorrect format,\nPress any key to try again!");
				return false;
			}
			if(result > a.Length)
			{
				Console.WriteLine("You have entered an incorrect number,\nPress any key to try again!");
				return false;
			}
			for (int i = 0; i < result; i++)
			{
				b += a[i];
			}
			Console.WriteLine(b);
			return true;
			//string result = a.Substring(0, n);
			//Console.WriteLine(result+ " " + "length of new string is " + result.Length);
		}
		static void Main(string[] args)
		{
			#region String concatanation and escaping
			// Normal string
			string name = "Bob";
			// Concatanation
			string hello1 = "Hello " + name;
			string hello2 = string.Format("Hello {0}", name);
			string hello3 = $"Hello {name}";
			// Escaping with \ character
			string a = "Check your c:\\ drive";
			string b = "We will have \"fair\" elections";
			string c = "The \\n sign means: new line";
			// Escaping a whole string with @
			string aa = @"Check your c:\ drive";
			string bb = @"We will have ""fair"" elections";
			string cc = @"The \n sign means: new line";
			string string1000 = string.Format(@"This is {0:P}", 0.5);
			Console.WriteLine($"{a} / {aa}");
			Console.WriteLine($"{b} / {bb}");
			Console.WriteLine($"{c} / {cc}");
			Console.ReadLine();
			#endregion
			#region String Formating
			// format string to currency
			string myStringCurrency = string.Format("{0:C}", 125.45);
			Console.WriteLine("Enter a number!");
			string fromUser = string.Format("{0:C}", int.Parse(Console.ReadLine()));
			// format string to number
			string myStringNumber = string.Format("{0:N}", 190);
			// format string to percent
			string myStringPercent = string.Format("{0:P}", .5);
			// custom format for string
			string myStringCustom = string.Format("{0:0##-###-###}", 078270396);
			// custom alignment to a string ( spaces after the , are how many spaces will be pushed on the right 
			// factoring in the characters of the word it self as well
			string myCustomAlignedString1 = string.Format("| {0,10} | {1,10} |", "Id", "Order");
			string myCustomAlignedString2 = string.Format("| {0,10} | {1,10} |", 25, "A box");
			Console.WriteLine(myCustomAlignedString1);
			Console.WriteLine(myCustomAlignedString2);
			Console.ReadLine();
			#endregion
			#region String Methods
			string ourString = "   We are learning C# and it is FUN and EASY. Okay maybe just FUN.    ";
			Console.WriteLine(ourString);

			// Makes our string Upper/Lower Case
			string lowe = ourString.ToLower();
			Console.WriteLine(lowe);
			string upper = ourString.ToUpper();
			Console.WriteLine(upper);

			// Prints the length of our string
			int ourLength = ourString.Length;
			Console.WriteLine(ourLength);

			// Splits the string and makes an array of strings (splits on character selected)
			string[] splited = ourString.Split('.');
			Console.WriteLine(splited[0]);
			Console.WriteLine(splited[1]);
			Console.WriteLine(splited[2]);
			// The line below is commented because there is no index 3 in our splited array
			//Console.WriteLine(splited[3]);

			// Checks if a string starts with some string given and returns true or false
			bool startsWith = ourString.StartsWith("   W");
			Console.WriteLine(startsWith);

			// Checks if a string exists and if so returns an index, if not -1
			int indexOfString = ourString.IndexOf("FUN");
			int nonExistingString = ourString.IndexOf("Nope");
			Console.WriteLine(indexOfString);
			Console.WriteLine(nonExistingString);

			// Cuts the string in to a substring that starts from index 5 and takes the next 16 characters
			string substring = ourString.Substring(5, 16);
			Console.WriteLine(substring);

			// Creates an array of characters with every character from our string
			char[] chars = ourString.ToCharArray();
			Console.WriteLine(chars.Length);
			Console.WriteLine(chars[6]);
			// Two ways to turn char[] back to string
			Console.WriteLine(string.Join("", chars));
			Console.WriteLine(new string(chars));

			// It trims the white spaces at the front and back of the string
			string trimmedString = ourString.Trim();
			Console.WriteLine(trimmedString);
			#endregion
			#region Exercise 3
			while(!SubstringsExercise()){
				Console.ReadLine();
			}
			Console.ReadLine();
			#endregion
		}
	}
}
