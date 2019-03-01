using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Data Types
			// Whole numbers
			int wholeNumber1 = 5;
			Int32 wholeNumber2 = 10; // int and Int32 are the same
			long hugeWholeNumber1 = 1000000000000000000;
			Int64 hugeWholeNumber2 = 1000000000000000000; // long and Int64 are the same
														  // Decimal
			double decimalNumber1 = 0.5444;
			// String ( must be with double quotation )
			string someString = "Hello there.";
			// Char ( must be with single quotation )
			char someCharacter = 'Y';
			// Boolean ( true or false )
			bool someTrueOrFalseValue = false;
			// var is not a type, it will inherit the type of our value on runtime
			var someVar = 5; // this will become Int32 someVar = 5;
			#endregion
			#region Variables

			// Operations in variables
			int sumOfTwoNumbers = 5 + 2;
			int someNumber1 = 5;
			int someNumber2 = 2;
			int SumOfTwoVariables = someNumber1 + someNumber2;
			// = means take the value of
			someNumber2 = someNumber1;
			// You can't take the value from another variable if its not the same type
			string someString1 = "this is another string";
			// If you uncomment the line bellow it will give you an error
			//someString1 = someNumber1;
			#endregion
			#region Exercises 1 - 4
			// Exercise 1
			int a1; // declaration
			a1 = 4; // initialization
			int b1;
			b1 = 12;
			int result1 = a1 / b1;
			Console.WriteLine("Exercise 1 int Result:" + result1);

			double a2 = 4;
			double b2 = 12;
			double result2 = a2 / b2;
			Console.WriteLine("Exercise 1 double Result:" + result2);
			Console.ReadLine();

			// Exercise 2
			string a3 = "Dejan";
			string b3 = "Jovanov";
			string result3 = a3 + " " + b3; // Adding empty space to divide the strings
			Console.WriteLine("Exercise 2 strings Result:" + result3);

			string a4 = "5";
			string b4 = "7";
			string result4 = a4 + b4;
			Console.WriteLine("Exercise 2 numbers Result:" + result4);
			Console.ReadLine();

			// Exercise 3
			int a5 = 9;
			string b5 = "Code";
			string result5 = a5 + b5;
			Console.WriteLine("Exercise 3 Result:" + result5);
			Console.ReadLine();

			// Exercise 4
			int credit = 102;
			int messageCost = 5;
			int messagesSent = credit / messageCost;
			Console.WriteLine("You can send: " + messagesSent + " messages!");
			Console.ReadLine();
			#endregion
		}
	}
}
