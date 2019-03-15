using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.SetType("dog");
            a.ID = 1;
            a.Name = "Sarko";
            a.Color = Animal.AnimalColors.Black;
            //Console.WriteLine(a.ReturnType());
            //Console.WriteLine(a.ID);
            //Console.WriteLine(a.Name);
            a.PrintInfo();
            a.Eat();

            Console.WriteLine("-----------------------------");

            Dog d = new Dog();
            d.ID = 2;
            //d.Name = "Dog 2";
            d.SetType("dog");
            d.Color = Animal.AnimalColors.Brown;
            d.PrintInfo();
            d.PropertyDog = "ddddddddddddd";
            Console.WriteLine($"Dog PropertyDog={d.PropertyDog}");
            d.Bark();
            d.Eat();

            Console.WriteLine("-----------------------------");

            Cat c = new Cat();
            c.ID = 3;
            c.Name = "Cat 3";
            c.SetType("cat");
            c.Color = Animal.AnimalColors.White;
            c.PrintInfo();
            c.Eat();

            Console.WriteLine("-----------------------------");

            Console.ReadLine();
        }
    }
}
