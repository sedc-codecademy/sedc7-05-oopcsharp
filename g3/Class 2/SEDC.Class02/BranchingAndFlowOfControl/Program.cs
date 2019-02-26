using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndFlowOfControl
{
	class Program
	{
		static void Main(string[] args)
		{
			#region if/else
			if (5 > 3)
			{
				Console.WriteLine("5 is larger than 3");
			}
			else
			{
				Console.WriteLine("5 is not larger than 3"); // Visual studio tells us here that this code will never be executed
			}

			Console.Write("Please enter a number: ");
			int someNumber = int.Parse(Console.ReadLine());
			if (someNumber > 0)
			{
				Console.Write("Number is positive");
			}
			else if (someNumber < 0)
			{
				Console.Write("Number is negative");
			}
			else
			{
				Console.Write("Number is zero");
			}
			#endregion
			#region switch
			int day = 3;
			switch (day)
			{
			case 1: // We can test multiple cases at a time if they have the same outcome
			case 2:
			case 3:
			case 4:
			case 5:
				Console.WriteLine("Work day :(");
				break;
			case 6:
			case 7:
				Console.WriteLine("WEEKEND! WOHO!");
				break;
			default:
				Console.WriteLine("There is no such day! Sorry!"); // This happens if none of the above passes
				break;
			}
			#endregion
			#region 5 - 7
			// Exercise 5
			Console.Write("Please enter number of trees: ");
			int trees = int.Parse(Console.ReadLine());
			int n = 8;
			int m = 5;
			int treeApples = n * 12 * trees;
			int result;
			if (treeApples % m == 0)
			{
				result = treeApples / m;
			}
			else
			{
				result = treeApples / m + 1;
			}
			Console.WriteLine("You would need :" + result + " baskets!");
			Console.ReadLine();

			// Exercise 6
			Console.Write("Enter a number: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.Write("Enter another number: ");
			int num2 = int.Parse(Console.ReadLine());
			int larger;
			if (num1 > num2)
			{
				larger = num1;
				Console.WriteLine("First is larger!");
			}
			else if (num2 > num1)
			{
				larger = num2;
				Console.WriteLine("Second is larger!");
			}
			else
			{
				larger = num1;
				Console.WriteLine("The numbers are equal!");
			}

			if (larger != 0)
			{
				if (larger % 2 == 0)
				{
					Console.WriteLine("Number is Even!");
				}
				else if (larger % 2 != 0)
				{
					Console.WriteLine("Number is Odd!");
				}
			}
			else
			{
				Console.WriteLine("You entered Zero. That is not even nore odd!");
			}

			// Exercise 7
			Console.WriteLine("Whats behind door 1,2,3");
			int door;
			bool isNumber = int.TryParse(Console.ReadLine(), out door);
			if (isNumber)
			{
				switch (door)
				{
				case 1:
					Console.WriteLine("You got a new car");
					break;
				case 2:
					Console.WriteLine("You got a new plane");
					break;
				case 3:
					Console.WriteLine("You got a new house");
					break;
				default:
					Console.WriteLine("That was not 1 2 or 3! Sorry!");
					break;
				}
			}
			else
			{
				Console.WriteLine("That was not a number! Sorry!");
			}
			#endregion
		}
	}
}
