using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerOddsCalculator
{
    public class Card
    {
        private readonly Suit _suit;
        private readonly Rank _rank;

        public Card(PokerOddsCalculator.Suit suit, PokerOddsCalculator.Rank rank)
        {
            // TODO: Complete member initialization
            _suit = suit;
            _rank = rank;
        }

        public Suit Suit
        {
            get { return _suit; }
        }

        public Rank Rank
        {
            get { return _rank; }
        }

        public string ToString()
        {
            return _rank.ToString() + " of " + _suit.ToString();
        }
    }

    public enum Suit
    {
        Hearts = 1,
        Diamonds = 2,
        Clubs = 3,
        Spades = 4
    }

    public enum Rank
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

    public struct PlayerHand
    {
        public Card PlayerCard1 { get; set; }

        public Card PlayerCard2 { get; set; }
    }

    public struct Table
    {
        public Card Flop1 { get; set; }

        public Card Flop2 { get; set; }

        public Card Flop3 { get; set; }

        public Card Turn { get; set; }

        public Card River { get; set; }
    }

    public struct Play
    {
        public PlayerHand PlayerHand
        {
            get 
            {
                return PlayerHand;
            }
        }

        public Table Table
        {
            get
            {
                return Table;
            }
        }
    }
}
