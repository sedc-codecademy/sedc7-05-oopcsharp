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
			int integerVariable1 = 5;
			int integerVariable2;
			integerVariable2 = -100;
			integerVariable2 = 12;
			float floatVariable = 2.5F;
			double doubleVariable = 2.5;
			string stringVariable = "Hello SEDC!";
			char characterVariable = 'd';
			bool booleanVariable = false;
			long longerInteger = 3242343243243242342;
			int sumOfTwoNumbers = 2 + 6;
			sumOfTwoNumbers += 12;
			//sumOfTwoNumbers++;
			bool isLarger = 6 > 12;
			Console.WriteLine(isLarger);
			bool someExpression = true;
			someExpression &= isLarger;
			var x = 5;
			//x = "Bobi";
			Console.WriteLine(someExpression);
			//Console.WriteLine(sumOfTwoNumbers++);
			//Console.WriteLine(sumOfTwoNumbers++);
			//Console.WriteLine(sumOfTwoNumbers);
			//Console.WriteLine(integerVariable1);
			//Console.WriteLine(integerVariable2);
			Console.ReadLine();
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
