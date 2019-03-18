using Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackPlayer: Player
    {
        public int GetHandValue()
        {
            int result = 0;
            foreach (var card in Cards)
            {
                if (card.Rank == Rank.Ace)
                {
                    continue;
                }
                switch (card.Rank)
                {
                    case Rank.Two:
                        result += 2;
                        break;
                    case Rank.Three:
                        result += 3;
                        break;
                    case Rank.Four:
                        result += 4;
                        break;
                    case Rank.Five:
                        result += 5;
                        break;
                    case Rank.Six:
                        result += 6;
                        break;
                    case Rank.Seven:
                        result += 7;
                        break;
                    case Rank.Eight:
                        result += 8;
                        break;
                    case Rank.Nine:
                        result += 9;
                        break;
                    case Rank.Ten:
                    case Rank.Jack:
                    case Rank.Queen:
                    case Rank.King:
                        result += 10;
                        break;
                }
            }

            foreach (var card in Cards)
            {
                if (card.Rank != Rank.Ace)
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
