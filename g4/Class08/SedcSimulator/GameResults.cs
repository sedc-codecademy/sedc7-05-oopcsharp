using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class GameResults
    {
        public string[] PlayerNames { get; private set; }
        public int[] HandValues { get; private set; }
        public bool[] WinLose { get; private set; }

        public int DealerValue { get; private set; }
        public bool IsDealerBusted { get; private set; }

        public GameResults(List<BlackJackPlayer> players, BlackJackPlayer dealer)
        {
            PlayerNames = new string[players.Count];
            HandValues = new int[players.Count];
            WinLose = new bool[players.Count];

            DealerValue = dealer.GetHandValue();
            IsDealerBusted = DealerValue > 21;

            for (int i = 0; i < players.Count; i++)
            {
                PlayerNames[i] = players[i].Name;
                int value = players[i].GetHandValue();
                HandValues[i] = value;
                if (value > 21)
                {
                    WinLose[i] = false;
                }
                else
                {
                    if (IsDealerBusted)
                    {
                        WinLose[i] = true;
                    }
                    else
                    {
                        WinLose[i] = value >= DealerValue;
                    }
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < PlayerNames.Length; i++)
            {
                sb.AppendLine($"{PlayerNames[i]} has a hand value of {HandValues[i]}");
                if (WinLose[i])
                {
                    sb.AppendLine($"{PlayerNames[i]} has won");
                }
                else
                {
                    sb.AppendLine($"{PlayerNames[i]} lost");
                }
            }
            sb.AppendLine($"The dealer has a hand value of {DealerValue}");
            return sb.ToString();
        }
    }
}