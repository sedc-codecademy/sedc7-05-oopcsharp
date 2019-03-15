using System;
using System.Collections.Generic;

namespace SedcSimulator
{
    public class Student : Person
    {
        public List<bool> Attendance { get; set; }
        public List<bool> Homeworks { get; set; }
        public string StudentId { get; set; }
        public string Evaluation { get; set; }

        public override string GetFullName()
        {
            string parentValue = base.GetFullName();
            return $"#{StudentId}: {parentValue}";
        }

        public Student(string studentId, string firstName, string lastName) : base(firstName, lastName)
        {
            Console.WriteLine("In Student constructor");
            StudentId = studentId;
        }

    }
}