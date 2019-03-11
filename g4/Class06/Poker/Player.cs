using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player()
        {
            Cards = new List<Card>();
        }

        internal void GetCard(Card card)
        {
            Cards.Add(card);
        }

        public void DiscardCards()
        {
            Cards.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name); 
            foreach (var card in Cards)
            { 
                sb.AppendLine($"  {card}");
            }
            return sb.ToString();
        }
    }
}