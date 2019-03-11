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

        public Card TopCard {
            get {
                Card result = Cards[0];
                Cards.Remove(result);
                return result;
            }
        }

        public Deck()
        {
            Cards = new List<Card>();
            string[] ranks = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
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

        public void Shuffle()
        {
            Random r = new Random();
            Cards = Cards.OrderBy(card => r.Next()).ToList();
        }
    }
}
