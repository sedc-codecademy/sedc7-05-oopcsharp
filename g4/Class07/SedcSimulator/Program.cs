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
            var vukasin = new Student("123", "Vukasin", "Obradovic");
            Console.WriteLine(vukasin.GetFullName());

            //Person person = student;
            //Console.WriteLine(person.GetFullName());

            var availability = new List<DayOfWeek> { DayOfWeek.Monday, DayOfWeek.Friday };
            var wekoslav = new Lecturer("Wekoslav", "Stefanovski", availability);

            Console.WriteLine(wekoslav.GetFullName());

            //person = lecturer;
            //Console.WriteLine(person.GetFullName());

            Console.WriteLine("-------------");
            var persons = new List<Person>();
            persons.Add(vukasin);
            persons.Add(wekoslav);

            foreach (Person person in persons)
            {
                Console.WriteLine(person.GetFullName());
            }



        }
    }
}
