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
            var pound = new Pound();
            pound.Name = "Vardarishte";
            
            // create two dogs;
            Dog fido;
            Dog rex;

            pound.AddDog(fido);
            pound.AddDog(rex);

            fido.Play();

            string[] responses = pound.FeedTheDogs();
            // print the dogs responses

            fido.Play();
            Dog[] hungryDogs = pound.GetHungryDogs();
            // print the hungry dogs

            Dog poodle = pound.FindByBreed("Poodle");

            Console.WriteLine(poodle);

        }
    }
}
