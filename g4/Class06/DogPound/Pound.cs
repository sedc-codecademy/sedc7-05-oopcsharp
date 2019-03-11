using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogPound
{
    class Pound
    {
        public string Name { get; set; }

        Dog[] dogs = new Dog[100];

        // hack: this is both
        // - the current number of dogs we have
        // - the index of the next dog
        int occupancy = 0;

        internal void AddDog(Dog dog)
        {
            dogs[occupancy] = dog;
            occupancy += 1;
        }

        internal string[] FeedTheDogs()
        {
            List<string> results = new List<string>();
            for (int i = 0; i < occupancy; i++)
            {
                var dog = dogs[i];
                results.Add(dog.Eat());
            }
            return results.ToArray();

            // return dogs.Select(dog => dog.Eat()).ToArray();
        }

        internal Dog[] GetHungryDogs()
        {
            List<Dog> hungryDogs = new List<Dog>();
            for (int i = 0; i < occupancy; i++)
            {
                var dog = dogs[i];
                if (dog.IsHungry)
                {
                    hungryDogs.Add(dog);
                }
            }
            return hungryDogs.ToArray();
            //return dogs.Where(dog => dog.IsHungry).ToArray();
        }

        internal Dog FindByBreed(string breed)
        {
            for (int i = 0; i < occupancy; i++)
            {
                var dog = dogs[i];
                if (dog.Breed == breed)
                {
                    return dog;
                }
            }
            return null;
        }

        public override string ToString()
        {
            return $"The pound '{Name}' has {occupancy} dogs";
        }
    }
}
