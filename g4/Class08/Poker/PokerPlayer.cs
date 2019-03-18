using System;
using System.Linq;
using System.Collections.Generic;
using Cards;

namespace Poker
{
    public class PokerPlayer : Player
    {
        internal HandValue GetHandValue()
        {
            var rankGroups = Cards.GroupBy(card => card.Rank);

            if (rankGroups.Count() == 5)
            {
                // todo: check exotics
                return new HandValue
                {
                    HandType = HandType.HighCard,
                    HighCard = Cards.Select(card => GetCardValue(card.Rank)).Max()
                };
            }

            if (rankGroups.Count()==4)
            {
                var pair = rankGroups.Single(group => group.Count() == 2);
                return new HandValue
                {
                    HandType = HandType.SinglePair,
                    HighCard = GetCardValue(pair.Key)
                };
            }

            // todo, todo, todo, todo, todo, toodoooo

            // 1. check if all cards are different
            // hint use grouping
            return HandValue.GetEmpty();

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
                {Rank.Jack, 11},
                {Rank.Queen, 12},
                {Rank.King, 13},
                {Rank.Ace, 14},
            };

            if (values.ContainsKey(rank))
            {
                return values[rank];
            }

            throw new Exception($"Invalid card {rank}");

        }

        public static PokerPlayer GetHighCardPlayer()
        {
            return new PokerPlayer
            {
                Name = "High Card Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.Three, Suit.Clubs),
                    new Card(Rank.Five, Suit.Diamonds),
                    new Card(Rank.Eight, Suit.Clubs),
                    new Card(Rank.Jack, Suit.Hearts),
                }
            };
        }

        public static PokerPlayer GetOnePairPlayer()
        {
            return new PokerPlayer
            {
                Name = "One Pair Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.Three, Suit.Clubs),
                    new Card(Rank.Five, Suit.Diamonds),
                    new Card(Rank.Five, Suit.Clubs),
                    new Card(Rank.Jack, Suit.Hearts),
                }
            };
        }

        public static PokerPlayer GetTwoPairPlayer()
        {
            return new PokerPlayer
            {
                Name = "Two Pair Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.Three, Suit.Clubs),
                    new Card(Rank.Five, Suit.Diamonds),
                    new Card(Rank.Five, Suit.Clubs),
                    new Card(Rank.Three, Suit.Hearts),
                }
            };
        }

        public static PokerPlayer GetThreeKindPlayer()
        {
            return new PokerPlayer
            {
                Name = "Three of a Kind Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.Three, Suit.Clubs),
                    new Card(Rank.Five, Suit.Diamonds),
                    new Card(Rank.Five, Suit.Clubs),
                    new Card(Rank.Five, Suit.Hearts),
                }
            };
        }

        public static PokerPlayer GetFullHousePlayer()
        {
            return new PokerPlayer
            {
                Name = "Full House Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.Ace, Suit.Clubs),
                    new Card(Rank.Five, Suit.Diamonds),
                    new Card(Rank.Five, Suit.Clubs),
                    new Card(Rank.Five, Suit.Hearts),
                }
            };
        }

        public static PokerPlayer GetFourKindPlayer()
        {
            return new PokerPlayer
            {
                Name = "Four of a Kind Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.Five, Suit.Spades),
                    new Card(Rank.Five, Suit.Diamonds),
                    new Card(Rank.Five, Suit.Clubs),
                    new Card(Rank.Five, Suit.Hearts),
                }
            };
        }

        public static PokerPlayer GetStraightPlayer()
        {
            return new PokerPlayer
            {
                Name = "Straight Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Six, Suit.Spades),
                    new Card(Rank.Three, Suit.Clubs),
                    new Card(Rank.Five, Suit.Diamonds),
                    new Card(Rank.Two, Suit.Clubs),
                    new Card(Rank.Four, Suit.Hearts),
                }
            };
        }

        public static PokerPlayer GetFlushPlayer()
        {
            return new PokerPlayer
            {
                Name = "Flush Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.Three, Suit.Spades),
                    new Card(Rank.Five, Suit.Spades),
                    new Card(Rank.Eight, Suit.Spades),
                    new Card(Rank.Jack, Suit.Spades),
                }
            };
        }

        public static PokerPlayer GetStraightFlushPlayer()
        {
            return new PokerPlayer
            {
                Name = "Straight Flush Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Six, Suit.Spades),
                    new Card(Rank.Three, Suit.Spades),
                    new Card(Rank.Five, Suit.Spades),
                    new Card(Rank.Two, Suit.Spades),
                    new Card(Rank.Four, Suit.Spades),
                }
            };
        }

        public static PokerPlayer GetRoyalFlushPlayer()
        {
            return new PokerPlayer
            {
                Name = "Royal Flush Player",
                Cards = new List<Card>
                {
                    new Card(Rank.Ace, Suit.Spades),
                    new Card(Rank.King, Suit.Spades),
                    new Card(Rank.Ten, Suit.Spades),
                    new Card(Rank.Jack, Suit.Spades),
                    new Card(Rank.Queen, Suit.Spades),
                }
            };
        }

    }
}