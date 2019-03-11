using System;
using Classes.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Human
            Console.Write("Enter name: ");
            string hName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string hLName = Console.ReadLine();
            Console.Write("Enter nickname: ");
            string hNickname = Console.ReadLine();
            Console.Write("Enter age: ");
            int hAge = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Address address = new Address("Ruzveltova", 3, 1000, "Skopje");
            //Human me = new Human(hName, hLName, hAge);
            Human bt = new Human(hName, hNickname, hLName, hAge, address);
            Human otherHuman = new Human();
            //Console.WriteLine(me.Name);
            //Console.WriteLine(me.LastName);
            Console.WriteLine(bt.Address);
            //Console.WriteLine(bt.GetPersonStats());
            #endregion

            #region Dog

            //Dog myDog = new Dog("Bubic", "Trkacko", "Petrolej");

            //Console.WriteLine("What do you want the dog to do? \n" +
            //    "1) Eat \n" +
            //    "2) Play \n" +
            //    "3) Chase tail");
            //string option = Console.ReadLine();

            //switch (option)
            //{
            //    case "1":
            //        Console.WriteLine(myDog.Eat());
            //        break;
            //    case "2":
            //        Console.WriteLine(myDog.Play());
            //        break;
            //    case "3":
            //        Console.WriteLine(myDog.ChaseTail());
            //        break;
            //    default:
            //        Console.WriteLine("You chose wrong, need to be between 1-3");
            //        break;
            //}

            #endregion
            Console.ReadLine();
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public Dog(string name, string race, string color)
        {
            this.Name = name;
            this.Race = race;
            this.Color = color;
        }

        public string Eat()
        {
            return $"{this.Name} is eating";
        }
        public string Play()
        {
            return $"{this.Name} is playing";
        }
        public string ChaseTail()
        {
            return $"{this.Name} is chasing its tail";
        }
    }

    public class Human
    {
        public Human(string name, int age, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;

        }
        public Human(string name, string nickname, string lastName, int age, Address address)
        {
            this.Name = name;
            Nickname = nickname;
            this.LastName = lastName;
            this.Age = age;
            this.Address = address;
        }
        public Human() { }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public int Age { get; set; }

        public string GetPersonStats()
        {
            return $"Hi my name is {this.Name} {LastName} and I'm {Age} years old \n" +
                $"and I live on street: {Address.Street} {Address.Number} in {Address.City}";
        }
    }
}
