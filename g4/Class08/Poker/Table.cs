using Cards;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    internal class Table
    {
        public Deck Deck { get; set; }
        public List<PokerPlayer> Players { get; set; }

        public Table()
        {
            Players = new List<PokerPlayer>();
        }

        public void AddPlayer(PokerPlayer player)
        {
            Players.Add(player);
        }

        public void StartNewGame()
        {
            Deck = new Deck();
            Deck.Shuffle();

            foreach (var player in Players)
            {
                player.DiscardCards();
            }

            for (int i = 0; i < 5; i++)
            {
                foreach (var player in Players)
                {
                    player.GetCard(Deck.GetTopCard());
                }
            }
        }

        public GameResults GetResults()
        {
            var results = new GameResults(Players);
            return results;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var player in Players)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString();
        }
    }
}