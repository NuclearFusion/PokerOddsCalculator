﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerOddsCalculator
{
    public class Card
    {
        private readonly Suit _suit;
        private readonly Value _value;

        public Card(int a_nNumber)
        {
            _suit = (Suit)(a_nNumber / 13);  // 0 = Hearts, 1 = Diamonds ...
            _value = (Value)(a_nNumber % 13 + 1);  // 1 = ace, 2 = two
        }

        public Card(PokerOddsCalculator.Suit suit, PokerOddsCalculator.Value value)
        {
            // TODO: Complete member initialization
            _suit = suit;
            _value = value;
        }
        
        public Suit Suit
        {
            get { return _suit; }
        }

        public Value Value
        {
            get { return _value; }
        }

        public int ToNumber()
        {
            return (int)_suit * 13 + ((int)_value - 1);
        }
    }

    public enum Suit
    {
        Hearts = 0,
        Diamonds = 1,
        Clubs = 2,
        Spades = 3
    }

    public enum Value
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
        King = 13,
    }
}
