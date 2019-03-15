using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Maze maze = new Maze();

            MazeRoom room = new MazeRoom
            {
                Name = "The Room",
                HasNorthDoor = true,
                HasEastDoor = true
            };

            room.CheckDoors();



        }
    }
}
