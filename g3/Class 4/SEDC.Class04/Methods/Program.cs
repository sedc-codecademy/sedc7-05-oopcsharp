using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	class Program
	{
		// Function with no parameters, no return ( void )
		static void CheckDroids1()
		{
			Console.WriteLine("These aren't the droids you are looking for.");
			Console.ReadLine();
		}

		// Function with parameters but no reutrn ( void )
		static void CheckDroids2(bool isJedi)
		{
			if (isJedi)
			{
				Console.WriteLine("These aren't the droids you are looking for.");
			}
			else
			{
				Console.WriteLine("Take the droids. It's cool.");
			}
			Console.ReadLine();
		}

		static string JediMindTrick(){
			return "These aren't the droids you are looking for.";
		}
		// Function with parameters and return
		static string CheckDroids3(bool isJedi)
		{
			if (isJedi)
			{
				return JediMindTrick(); // We can call functions inside of functions
			}
			else
			{
				return "Take the droids. It's cool.";
			}
		}
		
		void nonStaticMethod()
		{
			Console.WriteLine("This is a non-static method");
			Console.ReadLine();
		}

		static int Sum(int num1, int num2)
		{
			return num1 + num2;
		}
		static int Subtract(int num1, int num2)
		{
			return num1 - num2;
		}
		static void Exercise1()
		{
			Console.Write("Enter an operation ( + or - ):");
			string operation = Console.ReadLine();
			if (operation != "+" && operation != "-")
			{
				Console.WriteLine("Sorry! Wrong input!");
				return;
			}
			Console.Write("Enter first number:");
			int number1 = int.Parse(Console.ReadLine());
			Console.Write("Enter second number:");
			int number2 = int.Parse(Console.ReadLine());
			if (operation == "+") Console.WriteLine(Sum(number1, number2));
			if (operation == "-") Console.WriteLine(Subtract(number1, number2));
			
		}

		static void Main(string[] args)
		{
			// Calling the methods
			CheckDroids1();
			CheckDroids2(true);
			// We can store return values in a variable
			string result = CheckDroids3(false);
			Console.WriteLine(result);
			// Or use it on the spot where we need the result
			Console.WriteLine(CheckDroids3(false));
			Console.ReadLine();
			new Program().nonStaticMethod();
			// Exercise 1
			Exercise1();
		}
	}
}
