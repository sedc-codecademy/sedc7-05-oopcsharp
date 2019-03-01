using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
	class Program
	{
		static void Main(string[] args)
		{
			#region For Loop
			// Simple for example
			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();

			// Infinite for loop
			//for (;;)
			//{
			//	Console.WriteLine("This will go on forever!");
			//}
			//Console.ReadLine();

			// Loops indefinetly unless a condition in the block is met
			for (; ; )
			{
				Console.WriteLine("This will go on forever unless you enter X!");
				string input = Console.ReadLine();
				if (input == "X" || input == "x") break;
			}
			Console.ReadLine();

			// Creating a droid army with a for
			Console.WriteLine("Creating a droid army:");
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine("Assembling Droid Batalion " + i);
				if (i == 5)
				{
					// Continue stops the current loop and continues with the others
					Console.WriteLine("Problem in assembling with Droid batalion " + i);
					continue;
				}
				if (i == 7)
				{
					// Break stops the whole for and continues forward with the code
					Console.WriteLine("Droid Assembler broke down!");
					break;
				}
				Console.WriteLine("Droid Batalion " + i + " is operational.");
			}
			Console.ReadLine();
			#endregion
			#region While Loop
			// Simple while loop
			int whileCounter = 0;
			while(whileCounter < 10)
			{
				Console.WriteLine(whileCounter);
			}
			Console.ReadLine();

			// Infinite while loop
			//while(true)
			//{
			//	Console.WriteLine("This will go on forever!");
			//}
			//Console.ReadLine();

			// Loops indefinetly unless a condition in the block is met
			while (true)
			{
				Console.WriteLine("This will go on forever unless you enter X!");
				string input = Console.ReadLine();
				if (input == "X" || input == "x") break;
			}
			Console.ReadLine();

			// Create a droid army with while
			Console.WriteLine("Creating a Clone army:");
			int whileDroids = 1;
			while (whileDroids <= 10)
			{
				Console.WriteLine("Cloning Clone Batalion " + whileDroids);
				if (whileDroids == 5)
				{
					Console.WriteLine("Problem in cloning Clone batalion " + whileDroids);
					whileDroids++;
					continue;
				}
				if (whileDroids == 7)
				{
					Console.WriteLine("Cloning machine broke down!");
					whileDroids++;
					break;
				}
				Console.WriteLine("Clone Batalion " + whileDroids + " is operational.");
				whileDroids++;
			}
			Console.ReadLine();
			#endregion
			#region Do-While Loop
			// Simple do-while loop
			int doWhileCounter = 0;
			do
			{
				Console.WriteLine(doWhileCounter);
			}
			while (doWhileCounter < 10);

			// Do-While loop that is false
			do
			{
				Console.WriteLine("This will be executed once!");
			}
			while (false);
			#endregion
			#region Exercise 1 - 3
			// Exercise 1
			Console.WriteLine("Enter a number:");
			int ex1input1 = int.Parse(Console.ReadLine());
			for (int i = 1; i <= ex1input1; i++)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("Enter another number:");
			int ex1input2 = int.Parse(Console.ReadLine());
			for (int i = ex1input2; i != 0; i--)
			{
				Console.WriteLine(i);
			}
			Console.ReadLine();

			// Exercise 2
			Console.WriteLine("Enter a number:");
			int ex2input1 = int.Parse(Console.ReadLine());
			for (int i = 2; i <= ex2input1; i++)
			{
				if(i % 2 == 0) Console.WriteLine(i);
			}
			Console.WriteLine("Enter another number:");
			int ex2input2 = int.Parse(Console.ReadLine());
			for (int i = 1; i <= ex2input2; i++)
			{
				if (i % 2 != 0) Console.WriteLine(i);
			}
			Console.ReadLine();

			// Exercise 3
			Console.WriteLine("Enter a number:");
			int ex3input = int.Parse(Console.ReadLine());
			for (int i = 1; i <= ex3input; i++)
			{
				if (i % 3 == 0 || i % 7 == 0) continue;
				if (i == 100) {
					Console.WriteLine("The limit is reached!");
					break;
				}
				Console.WriteLine(i);
			}
			Console.ReadLine();
			#endregion
		}
	}
}
