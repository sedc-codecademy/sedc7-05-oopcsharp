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
            sb.AppendLine($"Hand value is {GetHandValue()}");
            return sb.ToString();
        }

        public int GetHandValue()
        {
            int result = 0;
            foreach (var card in Cards)
            {
                if (card.Rank == "Ace")
                {
                    continue;
                }
                switch (card.Rank)
                {
                    case "Two":
                        result += 2;
                        break;
                    case "Three":
                        result += 3;
                        break;
                    case "Four":
                        result += 4;
                        break;
                    case "Five":
                        result += 5;
                        break;
                    case "Six":
                        result += 6;
                        break;
                    case "Seven":
                        result += 7;
                        break;
                    case "Eight":
                        result += 8;
                        break;
                    case "Nine":
                        result += 9;
                        break;
                    case "Ten":
                    case "Jack":
                    case "Queen":
                    case "King":
                        result += 10;
                        break;
                }
            }

            foreach (var card in Cards)
            {
                if (card.Rank != "Ace")
                {
                    continue;
                }
                if (result + 11 > 21)
                {
                    result += 1;
                }
                else
                {
                    result += 11;
                }
            }
            return result;
        }
    }
}