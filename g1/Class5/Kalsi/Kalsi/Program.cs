using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalsi
{
    class Program
    {
        class Car
        {
            public string Brand;
            public string Color;
            public string Engine;
            public double KWs;
            public string Fuel;
            public int Doors;
            //default konstruktor
            public Car() {
                Console.WriteLine("Constructing object");
            }
            public Car(string brand, string color, string fuel, int doors, 
                string engine, int kws)
            {
                this.Brand = brand;
                this.Color = color;
                this.Fuel = fuel;
                this.Doors = doors;
                this.Engine = engine;
                this.KWs = kws;
            }
            ~Car() {
                Console.WriteLine("Destructing object {0}",this.Brand);
            }

            public void PrintCar(Car c1)
            {
            Console.WriteLine("Brand: {0}, Color {1}," +
                            "Doors {2}, Engine {3}, KWs {4}, Fuel {5}",
                            c1.Brand, c1.Color, c1.Doors, c1.Engine, c1.KWs, 
                            c1.Fuel);
            }

        }

        class Student
        {
            public string FullName;
            public string Group;
            public string Academy;
            public Student(string fullName, string group, string academy)
            {
                this.FullName = fullName;
                this.Group = group;
                this.Academy = academy;
            }
        }
        static void Main(string[] args)
        {
            //Car c1 = new Car();
            //c1.Brand = "VW";
            //c1.Color = "Black";
            //c1.Doors = 5;
            //c1.Engine = "2.0 TDI";
            //c1.KWs = 104;
            //c1.Fuel = "Diesel";
            //c1.PrintCar(c1);
            //Console.ReadLine();

            //Car c2 = new Car("Toyota", "Silver", "Petrol", 3, "TSI", 90);
            //c2.PrintCar(c2);
            //Console.ReadLine();

            Student[] students = new Student[] 
            {
                new Student("Todor Janevski","G1", "SEDC" ),
                new Student("Goran Kuzmanoski","G1", "SEDC" ),
                new Student("Vladimir Poposki","G2", "SEDC" ),
                new Student("Monika Gjorgjievska","G1", "SEDC" ),
                new Student("Dejan Angelovski","G2", "SEDC" ),
            };

            Console.WriteLine("Vnesi ime na student.");
            string name = Console.ReadLine();

            Console.WriteLine("Vnesi grupa.");
            string group = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Group == group && students[i].FullName == name)
                {
                    Console.WriteLine("There is student named {0}", students[i].FullName);
                    found = true;
                    break;
                } 
            }

            if (!found)
            {
                Console.WriteLine("There is no student named {0}", name);
            }
            Console.ReadLine();
        }        
    }
}
