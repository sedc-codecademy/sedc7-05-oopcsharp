using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogPound
{
    class Program
    {
        static void Main(string[] args)
        {
            var pound = new Pound { Name = "Vardarishte" };

            // create two dogs;
            Dog fido = new Dog("Fido");
            fido.Breed = "Poodle";
            fido.Color = "black";

            Dog rex = new Dog("Rex");
            rex.Breed = "Labrador";
            rex.Color = "golden";

            pound.AddDog(fido);
            pound.AddDog(rex);

            Console.WriteLine(pound);

            Console.WriteLine(fido.Play());

            string[] responses = pound.FeedTheDogs();
            // print the dogs responses
            Console.WriteLine("Feeding the dogs");
            foreach (var response in responses)
            {
                Console.WriteLine($"  {response}");
            }

            Console.WriteLine(rex.Play());


            Dog[] hungryDogs = pound.GetHungryDogs();
            // print the hungry dogs
            Console.WriteLine("Hungry dogs:");
            foreach (var dog in hungryDogs)
            {
                Console.WriteLine($"  {dog}");
            }

            Dog poodle = pound.FindByBreed("Poodle");
            Console.WriteLine("Searching for poodle...");
            Console.WriteLine(poodle);

        }
    }
}
