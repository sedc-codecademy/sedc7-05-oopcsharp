using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogPound
{
    class Dog
    {
        public string Name { get; private set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        //private bool isHungry = false;
        public bool IsHungry { get; private set; }

        public Dog(string name)
        {
            Name = name;
            Breed = "Mongrel";
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Color))
            {
                return $"{Name} is a {Breed}";
            }
            else
            {
                return $"{Name} is a {Color}-colored {Breed}";
            }

        }

        public string Eat(string food = "dog food")
        {
            if (!IsHungry)
            {
                return $"{Name} is not hungry";
            }
            IsHungry = false;
            return $"{Name} is eating {food}";

        }

        public string Play()
        {
            if (IsHungry)
            {
                return $"{Name} is hungry, it doesn't want to play";
            }
            IsHungry = true;
            return $"{Name} is playing on its own";
        }

        public string Play(string toy)
        {
            if (IsHungry)
            {
                return $"{Name} is hungry, it doesn't want to play with {toy}";
            }
            IsHungry = true;
            return $"{Name} is playing with {toy}";
        }

        public string ChaseTail()
        {
            if (IsHungry)
            {
                return $"{Name} is hungry, it doesn't want to chase its tail";
            }
            IsHungry = true;
            return $"{Name} is chasing its tail";
        }
    }
}
