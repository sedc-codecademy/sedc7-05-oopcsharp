using System.Collections.Generic;

namespace Poker
{
    public class GameResults
    {
        public string[] PlayerNames { get; private set; }
        public HandType[] HandTypes { get; private set; }
        public int[] HighCardValue { get; private set; }

        //public string Winner { get; set; }

        public GameResults(List<PokerPlayer> players)
        {
            PlayerNames = new string[players.Count];
            HandTypes = new HandType[players.Count];
            HighCardValue = new int[players.Count];

            for (int i = 0; i < players.Count; i++)
            {
                PlayerNames[i] = players[i].Name;
                var handValue = players[i].GetHandValue();
                HighCardValue[i] = handValue.HighCard;
                HandTypes[i] = handValue.HandType;
            }
        }

    }
}