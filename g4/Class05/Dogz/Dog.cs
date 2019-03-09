using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogz
{
    class Dog
    {
        // private invisible, internal state
        // private bool isHungry = false;

        // public visible, internal state
        public bool IsHungry { get; private set; }

        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }

        public string Eat(string food)
        {
            if (!IsHungry)
            {
                return $"{Name} won't eat, it wants to play";
            }
            IsHungry = false;
            return $"{Name} is eating {food}";
        }

        public string Play()
        {
            if (IsHungry)
            {
                return $"{Name} won't play, it's hungry";
            }
            IsHungry = true;
            return $"{Name} is playing";
        }

        public string ChaseTail()
        {
            if (IsHungry)
            {
                return $"{Name} won't chase its tail, it's hungry";
            }
            IsHungry = true;
            return $"{Name} is chasing its tail";
        }

        public override string ToString()
        {
            return $"{Name} is a {Race} with a {Color} color";
        }

    }
}
