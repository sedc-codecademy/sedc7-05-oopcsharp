using System;
using System.Collections.Generic;

namespace Demo
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Genre FavoriteMusicType { get; set; }

        private List<Song> FavoriteSongs { get; set; }

        public Person(string firstName, string lastName, Genre favMusicType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FavoriteMusicType = favMusicType;
            FavoriteSongs = new List<Song>();
        }

        public void AddFavoriteSong(Song song)
        {
            this.FavoriteSongs.Add(song);
        }

        public void GetFavSongs()
        {
            if(FavoriteSongs.Count == 0)
            {
                Console.WriteLine("You dont listen to music :)");
            }
            else
            {
                foreach (Song song in FavoriteSongs)
                {
                    Console.WriteLine(song.SongInfo());
                }
            }
        }
    }
}
