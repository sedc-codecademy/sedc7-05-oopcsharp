using System;
using System.Collections.Generic;

namespace Exercises.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre favoritMusic)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoritMusic;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void GetFavSongs()
        {
            if (FavoriteSongs.Count > 0)
            {
                Console.WriteLine($"{GetFullName()} likes these songs:");

                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine($"{song.Title} {song.Genre} {song.Length}");
                }
            }
            else
            {
                Console.WriteLine($"Sorry but {GetFullName()} doesn't have any favorite songs");
            }
        }
    }
}