using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Arrays
			// An empty array with 3 elements
			int[] emptyIntArray = new int[3];
			// Adding items in the array
			emptyIntArray[0] = 12;
			emptyIntArray[1] = 3;
			emptyIntArray[2] = -12;
			// What an array looks like in the console
			Console.WriteLine(emptyIntArray);
			// Getting an item from the array
			Console.WriteLine(emptyIntArray[2]);
			// Trying to set a 4th item in the array
			emptyIntArray[3] = 22;
			// Creating and initialization of an array
			string[] fullStringArray = new string[] { "Bob", "Jill", "Greg", "Mia" };
			bool[] fullBoolArray = new bool[] { true, false, false, true, true };
			char[] fullCharacterArray = new char[] { 'b', '4', 'N', '%' };
			// A shorter way of initializing an array
			int[] shorterWayArray = { 14, 5, -10 };
			Console.WriteLine(shorterWayArray[2]);
			Console.ReadLine();
			#endregion
			#region Array Methods
			// Getting the number of elements from an array
			double[] doubleArray = new double[] { 2.4, 11, 12, 634, 0.99 };
			Console.WriteLine(doubleArray.Length);
			// Reversing an array
			Array.Reverse(doubleArray);
			Console.WriteLine(doubleArray[0]);
			// Finding something in an array
			int indexFound = Array.IndexOf(doubleArray, 12);
			Console.WriteLine(indexFound);
			int indexNotFound = Array.IndexOf(doubleArray, 5.5);
			Console.WriteLine(indexNotFound);
			// Change an array number of items
			Array.Resize(ref doubleArray, 6);
			doubleArray[5] = 105.6;
			Console.WriteLine(doubleArray[5]);
			Console.ReadLine();
			#endregion
			#region foreach
			string[] names = { "Will", "Sam", "Fiona", "May" };
			foreach (string name in names)
			{
				Console.WriteLine("Checking if name is Sam...");
				if(name == "Sam"){
					Console.WriteLine("We found Sam!");
					break;
				}
				
			}
			#endregion
			#region Exercise 4 - 5
			// Exercise 4
			string[] words = new string[]{ "Hello", "Hi", "Wow", "Words", "Dinosaur" };
			double[] decimals = new double[] { 2.4, 5.4444, 0.00009, 18.9, 999.0002 };
			char[] characters = new char[] { 'b', 'c', '0', '#', ']' };
			bool[] booleans = new bool[] { true, false, false, true, false };
			int[][] arraysOfInts = new int[][] {
				new int[] {2, 4},
				new int[] {-6, 12},
				new int[] {0, 99},
				new int[] {32, 27},
				new int[] {9999, 50}
			};

			// Exercise 5 Solution 1
			int[] arrayOfIntegers1 = new int[5];
			int sum1 = 0;
			for (int i = 0; i < arrayOfIntegers1.Length; i++)
			{
				Console.WriteLine("Enter index " + i);
				int number = int.Parse(Console.ReadLine());
				arrayOfIntegers1[i] = number;
			}
			foreach (int num in arrayOfIntegers1) sum1 += num;
			Console.WriteLine("The result is: " + sum1);
			Console.ReadLine();

			// Exercise 5 Solution 2
			int[] arrayOfIntegers2 = new int[5];
			int sum2 = 0;
			int j = 0;
			while ( j < arrayOfIntegers2.Length)
			{
				Console.WriteLine("Enter index " + j);
				if (!int.TryParse(Console.ReadLine(), out arrayOfIntegers2[j])) {
					Console.WriteLine("That was not a number!");
					continue;
				};
				sum2 += arrayOfIntegers2[j];
				j++;
				if (j == arrayOfIntegers2.Length ) Console.WriteLine("The result is: " + sum2);
			}
			Console.ReadLine();

			// Exercise 6 
			string[] fullNames = new string[0];
			int counter = 0;
			while(true){
				Console.WriteLine("Please enter a name from the keyboard:");
				string name = Console.ReadLine();
				Array.Resize(ref fullNames, fullNames.Length + 1);
				fullNames[counter] = name;
				Console.WriteLine("Names stored:");
				foreach (string currentName in fullNames)
				{
					Console.WriteLine(currentName);
				}
				Console.WriteLine("Do you want to enter another name?");
				if (Console.ReadLine() == "N") break;
                counter++;
            }
			#endregion
		}
	}
}
