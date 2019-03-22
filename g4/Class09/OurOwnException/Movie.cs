using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurOwnException
{
    class Movie
    {
        public int Rating { get; private set; }
        public string Name { get; private set; }

        public Movie (string name)
        {
            Name = name;
        }

        public void SetRating(int rating)
        {
            if (rating > 0 && rating <=10)
            {
                Rating = rating;
            }
            else
            {
                throw new MovieException("Rating is out of range");
            }
        }

        public override string ToString()
        {
            if (Rating != 0)
            {
                return $"The movie {Name} has a rating of {Rating} stars";
            }
            else
            {
                return $"The movie {Name} is unrated";
            }
        }


    }
}
