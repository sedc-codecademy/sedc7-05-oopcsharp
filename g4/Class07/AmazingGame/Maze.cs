using System.Collections.Generic;

namespace AmazingGame
{
    internal class Maze
    {
        public List<MazeRoom> Rooms { get; private set; }

        public Maze()
        {
            Rooms = new List<MazeRoom>();


        }

    }
}