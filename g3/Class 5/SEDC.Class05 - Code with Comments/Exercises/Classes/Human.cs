using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Classes
{
	public class Human
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string GetPersonStats()
		{
			return string.Format("Name:{0,20} Age:{1,6}", $"{FirstName} {LastName}", Age);
		}
	}
}
