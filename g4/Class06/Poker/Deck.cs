using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Ten", "10", "Jack", "Queen", "King" };
            string[] suits = { "Spades", "Hearts", "Clubs", "Diamonds" };

            foreach (var rank in ranks)
            {
                foreach (var suit in suits)
                {
                    var card = new Card(rank, suit);
                    Cards.Add(card);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            foreach (var card in Cards)
            {
                sb.AppendLine($"  {card}");
            }
            sb.AppendLine("]");
            return sb.ToString();
        }

    }
}
