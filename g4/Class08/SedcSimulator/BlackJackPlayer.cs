using Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackPlayer : Player
    {
        const int limit = 21;

        public int GetHandValue()
        {
            int result = Cards
               .Where(card => card.Rank != Rank.Ace)
               .Select(card => GetCardValue(card.Rank))
               .Sum();

            foreach (var card in Cards.Where(card => card.Rank == Rank.Ace))
            {
                if (result + 11 > limit)
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

        private int GetCardValue(Rank rank)
        {
            Dictionary<Rank, int> values = new Dictionary<Rank, int>
            {
                {Rank.Two, 2},
                {Rank.Three, 3},
                {Rank.Four, 4},
                {Rank.Five, 5},
                {Rank.Six, 6 },
                {Rank.Seven, 7},
                {Rank.Eight, 8},
                {Rank.Nine, 9},
                {Rank.Ten, 10},
                {Rank.Jack, 10},
                {Rank.Queen, 10},
                {Rank.King, 10}
            };

            if (values.ContainsKey(rank))
            {
                return values[rank];
            }

            throw new Exception($"Invalid card {rank}");
            
        }

        public override string ShowHand()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ShowHand());
            sb.AppendLine($"Hand value is {GetHandValue()}");
            return sb.ToString();
        }

    }
}
