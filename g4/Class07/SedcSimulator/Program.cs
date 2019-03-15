using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedcSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("A1", "Ime", "Prezime");

            Console.WriteLine(student.GetFullName());

            Person person = student;
            person.FirstName = "Vukasin";

            Console.WriteLine(student.GetFullName());
            Console.WriteLine(person.GetFullName());


        }
    }
}
