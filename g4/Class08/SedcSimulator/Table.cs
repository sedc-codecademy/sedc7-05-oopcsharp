using Cards;
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
        public List<BlackJackPlayer> Players { get; set; }
        public BlackJackPlayer Dealer { get; set; }

        public Table()
        {
            Dealer = new BlackJackPlayer { Name = "Dealer" };
            Players = new List<BlackJackPlayer>();
        }

        public void AddPlayer(BlackJackPlayer player)
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
                player.GetCard(Deck.GetTopCard());
            }
            Dealer.DiscardCards();
            Dealer.GetCard(Deck.GetTopCard());


            foreach (var player in Players)
            {
                player.GetCard(Deck.GetTopCard());
            }
            Dealer.GetCard(Deck.GetTopCard());
        }

        internal void PlayGame()
        {
            foreach (var player in Players)
            {
                while (player.GetHandValue() < 17)
                {
                    player.GetCard(Deck.GetTopCard());
                }
            }
            while (Dealer.GetHandValue() < 17)
            {
                Dealer.GetCard(Deck.GetTopCard());
            }

        }

        public GameResults GetResults()
        {
            var results = new GameResults(Players, Dealer);
            return results;
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
