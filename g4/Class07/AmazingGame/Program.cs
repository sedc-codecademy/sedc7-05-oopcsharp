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
            Maze maze = new Maze(GetRooms());
            Console.WriteLine(maze.Rooms.Count);
        }

        static List<MazeRoom> GetRooms()
        {
            return new List<MazeRoom>
            {
                new MazeRoom
                {
                    Name = "One",
                    HasEastDoor = true,
                    HasSouthDoor = true
                },
                new MazeRoom
                {
                    Name = "Two",
                    HasEastDoor = true,
                    HasWestDoor = true
                },
                new MazeRoom
                {
                    Name = "Three",
                    HasEastDoor = true,
                    HasWestDoor = true,
                    HasSouthDoor = true
                },
                new MazeRoom
                {
                    Name = "Four",
                    HasWestDoor = true,
                },
                new MazeRoom
                {
                    Name = "Five",
                    HasNorthDoor = true,
                },
                new MazeRoom
                {
                    Name = "Six",
                    HasNorthDoor = true,
                    HasSouthDoor = true,
                },
                new MazeRoom
                {
                    Name = "Seven",
                    HasNorthDoor = true,
                    HasSouthDoor = true,
                },
                new MazeRoom
                {
                    Name = "Eight",
                    HasEastDoor = true,
                },
                new MazeRoom
                {
                    Name = "Nine",
                    HasEastDoor = true,
                    HasWestDoor = true,
                },
                new MazeRoom
                {
                    Name = "Ten",
                    HasNorthDoor = true,
                    HasSouthDoor = true,
                    HasWestDoor = true,
                },
                new MazeRoom
                {
                    Name = "Eleven",
                    HasNorthDoor = true,
                    HasSouthDoor = true,
                },
                new MazeRoom
                {
                    Name = "Twelve",
                    HasEastDoor = true,
                },
                new MazeRoom
                {
                    Name = "Thirteen",
                    HasNorthDoor = true,
                    HasEastDoor = true,
                    HasWestDoor = true,
                },
                new MazeRoom
                {
                    Name = "Fourteen",
                    HasWestDoor = true,
                }
            };
        }
    }
}
