using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        public string Rank { get; private set; }
        public string Suit { get; private set; }

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }


    }
}
