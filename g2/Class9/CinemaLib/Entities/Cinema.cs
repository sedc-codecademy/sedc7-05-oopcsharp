using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaLib.Entities
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public string MoviePlaying(Movie movie)
        {
            return $"Watching {movie.Title}";
        }
    }
}
