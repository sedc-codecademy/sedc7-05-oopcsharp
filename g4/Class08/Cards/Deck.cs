using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            //string[] ranks = {  };
            //string[] suits = {  };

            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    var card = new Card(rank, suit);
                    Cards.Add(card);
                }
            }
        }

        public Card GetTopCard()
        {
            Card result = Cards[0];
            Cards.Remove(result);
            return result;
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
