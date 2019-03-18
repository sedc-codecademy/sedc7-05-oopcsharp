using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            var playerOne = new PokerPlayer { Name = "Player one" };
            var playerTwo = new PokerPlayer { Name = "Player Two" };
            var playerThree = new PokerPlayer { Name = "Player Three" };
            var playerFour = new PokerPlayer { Name = "Player Four" };

            table.AddPlayer(playerOne);
            table.AddPlayer(playerTwo);
            table.AddPlayer(playerThree);
            table.AddPlayer(playerFour);

            table.StartNewGame();

            Console.WriteLine(table);

            var results = table.GetResults();
            Console.WriteLine(results);
        }
    }
}
