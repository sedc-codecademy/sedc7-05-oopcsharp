using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player()
        {
            Cards = new List<Card>();
        }

        public void GetCard(Card card)
        {
            Cards.Add(card);
        }

        public void DiscardCards()
        {
            Cards.Clear();
        }

        public string ShowHand()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var card in Cards)
            {
                sb.AppendLine($"  {card}");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(ShowHand());
            return sb.ToString();
        }

    }

}
