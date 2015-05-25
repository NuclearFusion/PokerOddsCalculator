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
        Card[] Combination = new Card[0];
        OddsAndOutsResult Result = new OddsAndOutsResult();

        public OddsAndOutsCalculator(Play playInput)
        {
            Play = playInput;
            Combination[0] = Play.PlayerHand.PlayerCard1;
            Combination[1] = Play.PlayerHand.PlayerCard2;
            Combination[2] = Play.Table.Flop1;
            Combination[3] = Play.Table.Flop2;
            Combination[4] = Play.Table.Flop3;
            Combination[5] = Play.Table.Turn;
            Combination[6] = Play.Table.River;

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
                    if(Combination[i].Rank.ToString() == Combination[j].Rank.ToString())
                    {
                        Result.OnePair = 100;
                    }
                    else
                    {

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
