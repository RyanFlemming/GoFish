using System;
using System.Collections.Generic;

namespace GoFish
{
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            Value = value;
            Suit = suit;
        }
        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }
        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }

        public  static string Plural(Values value)
        {
            if (value == Values.Six)
            {
                return "Sixes";
            }
            else
            {
                return value.ToString() + "s";
            }
        }
    }


    public enum Suits : int
    {
        Spades = 0,
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3
    }

    public enum Values : int
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    class CardComparer_bySuit : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Suit > y.Suit)
            {
                return 1;
            }
            if (x.Suit < y.Suit)
            {
                return -1;
            }
            if (x.Value > y.Value)
            {
                return 1;
            }
            if (x.Value < y.Value)
            {
                return -1;
            }
            return 0;
        }
    }

    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value)
            {
                return 1;
            }
            if (x.Value < y.Value)
            {
                return -1;
            }
            return 0;
        }
    }
}
