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

        private string CheckDoorFlag(bool flag, string directionName)
        {
            if (flag)
            {
                return $"The \"{Name}\" room has a {directionName} door";
            }
            else
            {
                return $"The \"{Name}\" room does not have a {directionName} door";
            }
        }

        public string CheckDoor(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return CheckDoorFlag(HasNorthDoor, "northern");
                case Direction.South:
                    return CheckDoorFlag(HasSouthDoor, "southern");
                case Direction.East:
                    return CheckDoorFlag(HasEastDoor, "eastern");
                case Direction.West:
                    return CheckDoorFlag(HasWestDoor, "western");
                default:
                    throw new Exception("Something broke");
            }
        }

        public bool HasDoor(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    return HasNorthDoor;
                case Direction.South:
                    return HasSouthDoor;
                case Direction.East:
                    return HasEastDoor;
                case Direction.West:
                    return HasWestDoor;
                default:
                    throw new Exception("Something broke");
            }
        }

        public void CheckDoors()
        {
            Console.WriteLine(CheckDoor(Direction.North));
            Console.WriteLine(CheckDoor(Direction.South));
            Console.WriteLine(CheckDoor(Direction.East));
            Console.WriteLine(CheckDoor(Direction.West));
        }
    }
}