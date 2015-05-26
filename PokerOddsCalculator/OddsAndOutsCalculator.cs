using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerOddsCalculator
{
    public class OddsAndOutsCalculator
    {
        private Play Play;
        List<Card> Combination = new List<Card>();
        OddsAndOutsResult Result = new OddsAndOutsResult();

        public OddsAndOutsCalculator(Play playInput)
        {
            Play = playInput;
            if (playInput.PlayerHand.PlayerCard1 != null) { Combination.Add(new Card(playInput.PlayerHand.PlayerCard1.Suit, playInput.PlayerHand.PlayerCard1.Rank)); }
            if (playInput.PlayerHand.PlayerCard2 != null) { Combination.Add(new Card(playInput.PlayerHand.PlayerCard2.Suit, playInput.PlayerHand.PlayerCard2.Rank)); }
            if (playInput.Table.Flop1 != null) { Combination.Add(new Card(playInput.Table.Flop1.Suit, playInput.Table.Flop1.Rank)); }
            if (playInput.Table.Flop2 != null) { Combination.Add(new Card(playInput.Table.Flop2.Suit, playInput.Table.Flop2.Rank)); }
            if (playInput.Table.Flop3 != null) { Combination.Add(new Card(playInput.Table.Flop3.Suit, playInput.Table.Flop3.Rank)); }
            if (playInput.Table.Turn != null) { Combination.Add(new Card(playInput.Table.Turn.Suit, playInput.Table.Turn.Rank)); }
            if (playInput.Table.River != null) { Combination.Add(new Card(playInput.Table.River.Suit, playInput.Table.River.Rank)); }
            Card [] combination = Combination.ToArray();

            OnePair();

            Console.WriteLine(Result.OnePair);
        }

        public void RoyalFlush()
        {
            int Hearts = 0;
            int Diamonds = 0;
            int Clubs = 0;
            int Spades = 0;
            for (int i = 0; i < 7; i++)
            {
                if (Combination[i].Suit.ToString() == "1")
                {
                    Hearts++;
                }
                if (Combination[i].Suit.ToString() == "2")
                {
                    Diamonds++;
                }
                if (Combination[i].Suit.ToString() == "3")
                {
                    Clubs++;
                }
                if (Combination[i].Suit.ToString() == "4")
                {
                    Spades++;
                }
            }

            if(Hearts > 2)
            {

            }

            if(Diamonds > 2)
            {

            }

            if(Clubs > 2)
            {

            }

            if(Spades > 2)
            {

            }
        }

        public void StraightFlush()
        {

        }

        public void FourOfAKind()
        { 
        
        }

        public void FullHouse()
        {

        }

        public void Flush()
        {

        }

        public void Straight()
        {

        }

        public void ThreeOfAKind()
        {

        }

        public void TwoPair()
        {

        }

        public void OnePair()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if( i != j)
                    {
                        if (Combination[i].Rank.ToString() == Combination[j].Rank.ToString())
                        {
                            Result.OnePair = 100;
                        }
                        else
                        {

                        }
                    }
                }
            }
        }

        public struct OddsAndOutsResult
        {
            public decimal RoyalFlush;
            public decimal StraightFlush;
            public decimal FourOfAKind;
            public decimal FullHouse;
            public decimal Flush;
            public decimal Straight;
            public decimal ThreeOfAKind;
            public decimal TwoPair;
            public decimal OnePair;
        }
    }
}
