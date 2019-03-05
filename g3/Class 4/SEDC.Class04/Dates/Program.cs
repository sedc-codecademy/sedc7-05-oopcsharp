using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
	class Program
	{
		static void Exercise4()
		{
			DateTime today = DateTime.Today;
			Console.WriteLine(today.AddDays(3));
			Console.WriteLine(today.AddMonths(1).AddDays(3));
			Console.WriteLine(today.AddYears(-1).AddMonths(-2));
			Console.WriteLine(string.Format("{0:MMMM}", today));
			Console.WriteLine(string.Format("{0:yyyy}", today));
		}
		static void Main(string[] args)
		{
			#region Working With Dates
			// Creating an empty DateTime
			DateTime aDate = new DateTime();
			Console.WriteLine(aDate);
			// Creating a custom date          Year Month Day
			DateTime aCustomDate = new DateTime(1992, 10, 15);
			Console.WriteLine(aCustomDate);
			// The line bellow is commented out because DateTime cant use negative numbers
			//DateTime brokenTime = new DateTime(-1, 2, 5);

			// Converting from string to DateTime
			// Variations:
			//string stringDate = "12.15.2012";
			//string stringDate = "12/15/2012";
			//string stringDate = "12/15/12";
			//string stringDate = "dec.15.12";
			string stringDate = "12-15-2012";
			DateTime convertedDate = DateTime.Parse(stringDate);
			Console.WriteLine(convertedDate);
			// Creating a DateTime with the current Date
			DateTime currentDay = DateTime.Today;
			Console.WriteLine(currentDay);
			// Creating a DateTime with the current Date and Time
			DateTime currentDateTime = DateTime.Now;
			// Adding or removing days to a DateTime date
			DateTime addedDays = currentDateTime.AddDays(2);
			Console.WriteLine(addedDays);
			DateTime removedDays = currentDateTime.AddDays(-5);
			Console.WriteLine(removedDays);
			// Adding months to a DateTime date
			DateTime addedMonths = currentDateTime.AddMonths(2);
			Console.WriteLine(addedMonths);
			// Adding years to a DateTime date
			DateTime addedYears = currentDateTime.AddYears(2);
			Console.WriteLine(addedYears);
			// Adding hours to a DateTime date
			DateTime addedHours = currentDateTime.AddHours(3);
			Console.WriteLine(addedHours);
			// Get the number of the month from a DateTime
			int month = currentDateTime.Month;
			Console.WriteLine(month);
			// Get the number of the day from a DateTime
			int day = currentDateTime.Day;
			Console.WriteLine(day);
			// Get the number of the year from a DateTime
			int year = currentDateTime.Year;
			Console.WriteLine(year);
			// Formating dates
			string dateFormat1 = currentDateTime.ToString("MM/dd/yyyy");
			string dateFormat2 = currentDateTime.ToString("dddd, dd MMMM yyyy");
			string dateFormat3 = string.Format("Today is {0:MM/dd/yy}, {0:dddd}", currentDateTime);
			string dateFormat4 = string.Format("Today is {0:dd-MMMM-yyyy}, {0:t}", currentDateTime);
			Console.WriteLine(dateFormat1);
			Console.WriteLine(dateFormat2);
			Console.WriteLine(dateFormat3);
			Console.WriteLine(dateFormat4);
			Console.ReadLine();
			#endregion
			#region Exercise 4
			Exercise4();
			#endregion
		}
	}
}
