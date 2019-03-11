using ClassExample.Classes;
using System;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person1 = new Human();

            person1.FirstName = "Miodrag";
            person1.LastName = "Cekikj";
            person1.Birthdate = new DateTime(1989, 5, 15);
            person1.Address = "Address 11, Skopje, Macedonia";

            person1.PrintFullName();

            var person2 = new Human("Ivan", "Trajchev");

            person2.PrintFullName();

            Console.ReadLine();
        }
    }
}
