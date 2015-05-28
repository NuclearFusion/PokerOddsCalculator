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
        int combinationCardCount = 0;
        List<Card> Combination = new List<Card>();
        OddsAndOutsResult Result = new OddsAndOutsResult();
        double flopCardRoll;
        //double flopCardRoll2;
        //double flopCardRoll3;
        double turnRoll;
        double riverRoll;

        public OddsAndOutsCalculator(Play playInput)
        {
            Play = playInput;
            if (playInput.PlayerHand.PlayerCard1 != null) { 
                Combination.Add(new Card(playInput.PlayerHand.PlayerCard1.Suit, playInput.PlayerHand.PlayerCard1.Rank));
                combinationCardCount++;
            }
            if (playInput.PlayerHand.PlayerCard2 != null) { 
                Combination.Add(new Card(playInput.PlayerHand.PlayerCard2.Suit, playInput.PlayerHand.PlayerCard2.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Flop1 != null) { 
                Combination.Add(new Card(playInput.Table.Flop1.Suit, playInput.Table.Flop1.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Flop2 != null) { 
                Combination.Add(new Card(playInput.Table.Flop2.Suit, playInput.Table.Flop2.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Flop3 != null) { 
                Combination.Add(new Card(playInput.Table.Flop3.Suit, playInput.Table.Flop3.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Turn != null) { 
                Combination.Add(new Card(playInput.Table.Turn.Suit, playInput.Table.Turn.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.River != null) { 
                Combination.Add(new Card(playInput.Table.River.Suit, playInput.Table.River.Rank));
                combinationCardCount++;
            }
            
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
            if (combinationCardCount < 3)
            {
                Result.TwoPair = 0;
            }
            else
            {
                switch (combinationCardCount)
                {
                    case 2:
                        if (Combination[0].Rank == Combination[1].Rank)
                        {

                        }
                        else
                        { 
                        
                        }
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                }
            }
        }

        public void OnePair()
        {
            for (int i = 0; i < combinationCardCount; i++)
            {
                for (int j = 0; j < combinationCardCount; j++)
                {
                    if( i != j)
                    {
                        if (Combination[i].Rank == Combination[j].Rank)
                        {
                            Result.OnePair = 100;
                        }
                        else
                        {
                            switch (combinationCardCount) 
                            {
                                case 2:
                                    flopCardRoll = (6.0 / 50.0) * (45.0 / 49.0) * (44.0 / 48.0) * (43.0 / 47.0) * (42.0 / 46.0);
                                    Result.OnePair = Math.Round((flopCardRoll * 5) * 100, 1);
                                    break;
                                case 5:
                                    turnRoll = (6.0 / 50.0) * (45.0 / 49.0);
                                    Result.OnePair = Math.Round((turnRoll * 2) * 100, 1);
                                    break;
                                case 6:
                                    riverRoll = (6.0 / 50.0);
                                    Result.OnePair = Math.Round((riverRoll * 1) * 100, 1);
                                    break;
                            }
                        }
                    }
                }
            }
        }

        public struct OddsAndOutsResult
        {
            public double RoyalFlush;
            public double StraightFlush;
            public double FourOfAKind;
            public double FullHouse;
            public double Flush;
            public double Straight;
            public double ThreeOfAKind;
            public double TwoPair;
            public double OnePair;
        }
    }
}
