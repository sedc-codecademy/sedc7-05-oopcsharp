using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class HandValue
    {
        public HandType HandType { get; set; }
        public int HighCard { get; set; }

        public static HandValue GetEmpty()
        {
            return new HandValue
            {
                HandType = HandType.HighCard,
                HighCard = 0
            };
        }
    }
}
