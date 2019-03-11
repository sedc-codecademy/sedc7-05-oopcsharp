using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Table
    {
        public Deck Deck { get; set; }
        public List<Player> Players { get; set; }
        public Player Dealer { get; set; }
        
        public Table()
        {
            Dealer = new Player { Name = "Dealer" };
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
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
                player.GetCard(Deck.TopCard);
            }
            Dealer.DiscardCards();
            Dealer.GetCard(Deck.TopCard);

            foreach (var player in Players)
            {
                player.GetCard(Deck.TopCard);
            }
            Dealer.GetCard(Deck.TopCard);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Dealer.ToString());
            sb.AppendLine("Players:");
            foreach (var player in Players)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString();
        }

    }
}
