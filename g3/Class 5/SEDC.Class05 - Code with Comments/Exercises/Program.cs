using Exercises.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
	class Program
	{
		static Human GetHumanFromInput() {
			Human human = new Human();
			Console.Write("Enter human first name:");
			human.FirstName = Console.ReadLine();
			Console.Write("Enter human last name:");
			human.LastName = Console.ReadLine();
			Console.Write("Enter human age:");
			human.Age = int.Parse(Console.ReadLine());
			return human;
		}
		static void DogOptions(Dog dog, int option){
			switch (option)
			{
			case 1:
				Console.WriteLine(dog.Eat());
				break;
			case 2:
				Console.WriteLine(dog.Play());
				break;
			case 3:
				Console.WriteLine(dog.ChaseTail());
				break;
			default:
				Console.WriteLine("No option like that. Sorry.");
				break;
			}
			Console.ReadLine();
		}
		static void FindStudent(Student[] students, string name) {
			bool studentFound = false;
			while (studentFound == false)
			{
				foreach (var student in students)
				{
					if (name.ToLower() == student.Name.ToLower())
					{
						Console.WriteLine($"Student found: \n Name: {student.Name} \n Group: {student.Group} \n Academy: {student.Academy}");
						studentFound = true;
					}
				}
				if (studentFound == false)
				{
					Console.WriteLine("There is no such student, please try again");
					name = Console.ReadLine();
				}
			}
			Console.ReadLine();
		}
		static void Main(string[] args)
		{
			#region Exercise 1
			Human inputHuman = GetHumanFromInput();
			Console.WriteLine(inputHuman.GetPersonStats());
			Console.ReadLine();
			#endregion
			#region Exercise 2
			Dog aDog = new Dog();
			Console.WriteLine("Enter the dog's name");
			aDog.Name = Console.ReadLine();
			Console.WriteLine("Enter the dog's race");
			aDog.Race = Console.ReadLine();
			Console.WriteLine("Enter the dog's color");
			aDog.Color = Console.ReadLine();

			Console.WriteLine("What do you want the dog to do: \n 1. Feed the dog \n 2. Play \n 3. Let it chase it's tail");
			int result;
			while (!Int32.TryParse(Console.ReadLine(), out result))
			{
				Console.WriteLine("You have entered a wrong option");
				Console.WriteLine("What do you want the dog to do: \n 1. Eat \n 2. Play \n 3. Let it chase it's tail");
			}
			DogOptions(aDog, result);
			#endregion
			#region Exercise 3
			Student[] arrStudents = new Student[] {
				new Student("Bob", "G1", "Web Developemt"),
				new Student("Jill", "G2", "Design"),
				new Student("Greg", "G1", "Networks"),
				new Student("Anne", "G3", "Web Developemt"),
				new Student("Will", "G3", "Design")
			};

			Console.WriteLine("Enter a student name");
			string studentName = Console.ReadLine();
			FindStudent(arrStudents, studentName);
			#endregion
		}
	}
}
