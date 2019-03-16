using MusicApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, int age, Genre genre)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = genre;
        }

        public void GetFavSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine("This person hates music");
            } else
            {
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}
