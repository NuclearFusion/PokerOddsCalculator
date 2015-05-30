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
            if (playInput.PlayerHand.PlayerCard1 != null)
            {
                Combination.Add(new Card(playInput.PlayerHand.PlayerCard1.Suit, playInput.PlayerHand.PlayerCard1.Rank));
                combinationCardCount++;
            }
            if (playInput.PlayerHand.PlayerCard2 != null)
            {
                Combination.Add(new Card(playInput.PlayerHand.PlayerCard2.Suit, playInput.PlayerHand.PlayerCard2.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Flop1 != null)
            {
                Combination.Add(new Card(playInput.Table.Flop1.Suit, playInput.Table.Flop1.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Flop2 != null)
            {
                Combination.Add(new Card(playInput.Table.Flop2.Suit, playInput.Table.Flop2.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Flop3 != null)
            {
                Combination.Add(new Card(playInput.Table.Flop3.Suit, playInput.Table.Flop3.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.Turn != null)
            {
                Combination.Add(new Card(playInput.Table.Turn.Suit, playInput.Table.Turn.Rank));
                combinationCardCount++;
            }
            if (playInput.Table.River != null)
            {
                Combination.Add(new Card(playInput.Table.River.Suit, playInput.Table.River.Rank));
                combinationCardCount++;
            }

            Card[] combination = Combination.ToArray();

            OnePair();
            TwoPair();
            ThreeOfAKind();

            Console.WriteLine(Result.OnePair);
            Console.WriteLine(Result.TwoPair);
            Console.WriteLine(Result.ThreeOfAKind);
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

            if (Hearts > 2)
            {

            }

            if (Diamonds > 2)
            {

            }

            if (Clubs > 2)
            {

            }

            if (Spades > 2)
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
            int pCard1Match = 0;
            int pCard2Match = 0;
            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("ThreeOfAKind - Case 2: Initiated");
                    if (Combination[0].Rank == Combination[1].Rank)
                    {
                        flopCardRoll = (2.0 / 50.0) * (48.0 / 49.0) * (47.0 / 48.0) * (46.0 / 47.0) * (45.0 / 46.0);
                        Result.ThreeOfAKind = Math.Round((flopCardRoll * 5) * 100, 1);
                    }
                    else
                    {
                        flopCardRoll = (6.0 / 50.0) * (2.0 / 49.0) * (47.0 / 48.0) * (46.0 / 47.0) * (45.0 / 46.0);
                        Result.ThreeOfAKind = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    break;
                case 5:
                    Console.WriteLine("ThreeOfAKind - Case 5: Initiated");
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Rank == Combination[1].Rank)
                        {
                            pCard1Match++;
                            pCard2Match++;
                        }
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            pCard1Match++;
                        }
                        if (Combination[1].Rank == Combination[i].Rank)
                        {
                            pCard2Match++;
                        }
                    }
                    if (pCard1Match > 1 || pCard2Match > 1)
                    {
                        Result.ThreeOfAKind = 100;
                    }
                    else if (pCard1Match == 1 || pCard2Match == 1)
                    {
                        turnRoll = (2.0 / 47.0) * (45.0 / 46.0);
                        Result.ThreeOfAKind = Math.Round((turnRoll * 1) * 100, 1);
                    }
                    else
                    {
                        turnRoll = (3.0 / 47.0) * (2.0 / 46.0);
                        Result.ThreeOfAKind = Math.Round((turnRoll * 1) * 100, 1);
                    }
                    break;
                case 6:
                    Console.WriteLine("ThreeOfAKind - Case 6: Initiated");
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Rank == Combination[1].Rank)
                        {
                            pCard1Match++;
                            pCard2Match++;
                        }
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            pCard1Match++;
                        }
                        if (Combination[1].Rank == Combination[i].Rank)
                        {
                            pCard2Match++;
                        }
                    }
                    if (pCard1Match > 1 || pCard2Match > 1)
                    {
                        Result.ThreeOfAKind = 100;
                    }
                    else if (pCard1Match == 1 || pCard2Match == 1)
                    {
                        riverRoll = (2.0 / 46.0);
                        Result.ThreeOfAKind = Math.Round((riverRoll * 1) * 100, 1);
                    }
                    else
                    {
                        Result.ThreeOfAKind = 0;
                    }
                    break;
            }
        }

        public void TwoPair()
        {
            bool onePair = false;
            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("TwoPair - Case 2: Initiated");
                    if (Combination[0].Rank == Combination[1].Rank)
                    {
                        flopCardRoll = (48.0 / 50.0) * (3.0 / 49.0) * (44.0 / 48.0) * (43.0 / 47.0) * (42.0 / 46.0);
                        Result.TwoPair = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    else
                    {
                        flopCardRoll = (6.0 / 50.0) * (3.0 / 49) * (44.0 / 48.0) * (43.0 / 47.0) * (42.0 / 46.0);
                        Result.TwoPair = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    break;
                case 5:
                    Console.WriteLine("TwoPair - Case 5: Initiated");
                    if (Combination[0].Rank == Combination[1].Rank)
                    {
                        for (int i = 2; i < combinationCardCount; i++)
                        {
                            for (int j = 2; j < combinationCardCount; j++)
                            {
                                if (i != j)
                                {
                                    if (Combination[i].Rank == Combination[j].Rank)
                                    {
                                        Result.TwoPair = 100;
                                    }
                                }
                            }
                        }
                        if (Result.TwoPair != 100)
                        {
                            turnRoll = (45.0 / 47.0) * (3.0 / 46.0);
                            Result.TwoPair = Math.Round((turnRoll * 1) * 100, 1);
                        }
                    }
                    else
                    {
                        for (int i = 2; i < combinationCardCount; i++)
                        {
                            if (Combination[0].Rank == Combination[i].Rank)
                            {
                                for (int j = 2; j < combinationCardCount; j++)
                                {
                                    if (Combination[1].Rank == Combination[j].Rank)
                                    {
                                        Result.TwoPair = 100;
                                    }
                                }
                                onePair = true;
                            }
                        }
                        if (Result.TwoPair != 100 && onePair == true)
                        {
                            turnRoll = (45.0 / 47.0) * (3.0 / 46.0);
                            Result.TwoPair = Math.Round((turnRoll * 1) * 100, 1);
                        }
                        if (Result.TwoPair != 100 && onePair == false)
                        {
                            turnRoll = (6.0 / 47.0) * (3.0 / 46.0);
                            Result.TwoPair = Math.Round((turnRoll * 1) * 100, 1);
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("TwoPair - Case 6: Initiated");
                    if (Combination[0].Rank == Combination[1].Rank)
                    {
                        for (int i = 2; i < combinationCardCount; i++)
                        {
                            for (int j = 2; j < combinationCardCount; j++)
                            {
                                if (i != j)
                                {
                                    if (Combination[i].Rank == Combination[j].Rank)
                                    {
                                        Result.TwoPair = 100;
                                    }
                                }
                            }
                        }
                        if (Result.TwoPair != 100)
                        {
                            riverRoll = (3.0 / 46.0);
                            Result.TwoPair = Math.Round((riverRoll * 1) * 100, 1);
                        }
                    }
                    else
                    {
                        for (int i = 2; i < combinationCardCount; i++)
                        {
                            if (Combination[0].Rank == Combination[i].Rank)
                            {
                                for (int j = 2; j < combinationCardCount; j++)
                                {
                                    if (Combination[1].Rank == Combination[j].Rank)
                                    {
                                        Result.TwoPair = 100;
                                    }
                                }
                                onePair = true;
                            }
                        }
                        if (Result.TwoPair != 100 && onePair == true)
                        {
                            riverRoll = (3.0 / 46.0);
                            Result.TwoPair = Math.Round((riverRoll * 1) * 100, 1);
                        }
                        if (Result.TwoPair != 100 && onePair == false)
                        {
                            Result.TwoPair = 0;
                        }
                    }
                    break;
            }
        }

        public void OnePair()
        {
            Console.WriteLine("OnePair: Initiated");
            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("OnePair - Case 2: Initiated");
                    if (Combination[0].Rank == Combination[1].Rank)
                    {
                        Result.OnePair = 100;
                    }
                    else
                    {
                        flopCardRoll = (6.0 / 50.0) * (44.0 / 49.0) * (43.0 / 48.0) * (42.0 / 47.0) * (41.0 / 46.0);
                        Result.OnePair = Math.Round((flopCardRoll * 5) * 100, 1);
                    }
                    break;
                case 5:
                    Console.WriteLine("OnePair - Case 5: Initiated");
                    for (int i = 0; i < combinationCardCount; i++)
                    {
                        for (int j = 0; j < combinationCardCount; j++)
                        {
                            if (i != j)
                            {
                                if (Combination[i].Rank == Combination[j].Rank)
                                {
                                    Result.OnePair = 100;
                                }
                            }
                        }
                    }
                    if (Result.OnePair != 100)
                    {
                        turnRoll = (6.0 / 47.0) * (41.0 / 46.0);
                        Result.OnePair = Math.Round((turnRoll * 2) * 100, 1);
                    }
                    break;
                case 6:
                    Console.WriteLine("OnePair - Case 6: Initiated");
                    for (int i = 0; i < combinationCardCount; i++)
                    {
                        for (int j = 0; j < combinationCardCount; j++)
                        {
                            if (i != j)
                            {
                                if (Combination[i].Rank == Combination[j].Rank)
                                {
                                    Result.OnePair = 100;
                                }
                            }
                        }
                    }
                    if (Result.OnePair != 100)
                    {
                        riverRoll = (6.0 / 46.0);
                        Result.OnePair = Math.Round((riverRoll * 1) * 100, 1);
                    }
                    break;
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
