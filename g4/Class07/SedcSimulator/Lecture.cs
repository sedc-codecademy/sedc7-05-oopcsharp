using System.Collections.Generic;

namespace SedcSimulator
{
    public class Lecture
    {
        public string Title { get; set; }
        public Difficulty Difficulty { get; set; }
        public List<string> Homeworks { get; set; }
    }
}