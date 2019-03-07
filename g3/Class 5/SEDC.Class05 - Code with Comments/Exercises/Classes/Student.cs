using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Classes
{
	public class Student
	{
		public string Name { get; set; }
		public string Group { get; set; }
		public string Academy { get; set; }
		public Student(string name, string group, string academy)
		{
			Name = name;
			Group = group;
			Academy = academy;
		}
	}
}
