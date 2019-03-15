using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingGame
{
    public class MazeRoom
    {
        public string Name { get; set; }

        public bool HasNorthDoor { get; set; }
        public bool HasSouthDoor { get; set; }
        public bool HasWestDoor { get; set; }
        public bool HasEastDoor { get; set; }

        public string CheckDoor(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    break;
                case Direction.South:
                    break;
                case Direction.East:
                    break;
                case Direction.West:
                    break;
                default:
                    throw new Exception("Something broke");
            }
            return "NE RABOTE";
        }

        public void CheckDoors()
        {
            CheckDoor(Direction.North);
            CheckDoor(Direction.South);
            CheckDoor(Direction.East);
            CheckDoor(Direction.West);
        }
    }
}