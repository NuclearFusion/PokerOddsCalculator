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

        public override string ToString()
        {
            return _rank.ToString() + " of " + _suit.ToString();
        }

        public static Rank TextToRank(string cardName)
        {
            string[] splitCardName = cardName.Split(' ');
            switch (splitCardName[0])
            {
                case "Ace": return Rank.Ace;
                case "Two": return Rank.Two;
                case "Three": return Rank.Three;
                case "Four": return Rank.Four;
                case "Five": return Rank.Five;
                case "Six": return Rank.Six;
                case "Seven": return Rank.Seven;
                case "Eight": return Rank.Eight;
                case "Nine": return Rank.Nine;
                case "Ten": return Rank.Ten;
                case "Jack": return Rank.Jack;
                case "Queen": return Rank.Queen;
                case "King": return Rank.King;
                default: return Rank.Ace;
            }
        }

        public static Suit TextToSuit(string cardName)
        {
            string[] splitCardName = cardName.Split(' ');
            switch (splitCardName[2])
            {
                case "Hearts": return Suit.Hearts;
                case "Diamonds": return Suit.Diamonds;
                case "Clubs": return Suit.Clubs;
                case "Spades": return Suit.Spades;
                default: return Suit.Spades;
            }
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

    public struct Play
    {
        public PlayerHand PlayerHand { get; set; }


        public Table Table { get; set; }

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
}
