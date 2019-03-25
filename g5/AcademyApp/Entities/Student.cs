using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student : User
    {
        public Dictionary<Subject, int> Grades { get; set; }
        public Subject CurrentSubject { get; set; }
        public Student(string first, string last, string username, string password, Dictionary<Subject, int> grades, Subject currentSub )
        {
            FirstName = first;
            LastName = last;
            Username = username;
            Password = password;
            Grades = grades;
            CurrentSubject = currentSub;
            Role = Role.Student;
        }
        public void ShowGrades()
        {
            foreach (var item in Grades)
            {
                Console.WriteLine($"{item.Key.Title}: {item.Value}");
            }
        }

        public void Enroll(Subject subject)
        {
            CurrentSubject = subject;
        }
    }
}
