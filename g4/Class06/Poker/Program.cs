using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            //var deck = new Deck();
            //deck.Shuffle();
            //Console.WriteLine(deck);

            Table table = new Table();
            var playerOne = new Player { Name = "Player one" };
            var playerTwo = new Player { Name = "Player Two" };

            table.AddPlayer(playerOne);
            table.AddPlayer(playerTwo);

            table.StartNewGame();

            Console.WriteLine(table);
        }
    }
}
