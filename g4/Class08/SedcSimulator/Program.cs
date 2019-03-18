using Cards;
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
            Table table = new Table();
            var playerOne = new BlackJackPlayer { Name = "Player one" };
            var playerTwo = new BlackJackPlayer{ Name = "Player Two" };

            table.AddPlayer(playerOne);
            table.AddPlayer(playerTwo);

            table.StartNewGame();

            Console.WriteLine(table);

            table.PlayGame();

            Console.WriteLine(table);

            var results = table.GetResults();
            Console.WriteLine(results);
        }

    }
}
