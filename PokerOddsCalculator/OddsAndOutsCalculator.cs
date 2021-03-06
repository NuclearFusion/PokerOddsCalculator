﻿using System;
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
            Straight();
            Flush();

            FourOfAKind();
            StraightFlush();
            RoyalFlush();

            Console.WriteLine(Result.OnePair + " OnePair");
            Console.WriteLine(Result.TwoPair + " TwoPair");
            Console.WriteLine(Result.ThreeOfAKind + " ThreeOfAKind");
            Console.WriteLine(Result.Straight + " Straight");
            Console.WriteLine(Result.Flush + " Flush");
            Console.WriteLine(Result.FourOfAKind + " FourOfAKind");
            Console.WriteLine(Result.StraightFlush + " StraightFlush");
            Console.WriteLine(Result.RoyalFlush + " RoyalFlush");
        }

        public OddsAndOutsResult getResult()
        {
            return Result;
        }

        public void RoyalFlush()
        {
            bool addedCard = false;
            int royalFlushCombo = 0;
            List<Card> royalFlushDrawn = new List<Card>();

            for (int i = 10; i < 14; i++)
            {
                for (int j = 0; j < combinationCardCount; j++)
                {
                    if (i == (int)Combination[j].Rank)
                    {
                        royalFlushDrawn.Add(new Card(Combination[j].Suit, Combination[j].Rank, true));
                        addedCard = true;
                        break;
                    }
                    addedCard = false;
                }
                if (addedCard == false)
                {
                    royalFlushDrawn.Add(new Card(Suit.Clubs, (Rank)i, false));
                }
            }

            for (int k = 0; k < combinationCardCount; k++)
            {
                if (Combination[k].Rank == Rank.Ace)
                {
                    royalFlushDrawn.Add(new Card(Combination[k].Suit, Combination[k].Rank, true));
                    break;
                }
            }
            Console.WriteLine(royalFlushDrawn.Count);
            for (int j = 0; j < royalFlushDrawn.Count; j++)
            {
                if (royalFlushDrawn[j].Drawn == true && royalFlushDrawn[j].Suit == royalFlushDrawn[0].Suit)
                {
                    royalFlushCombo++;
                }
            }

            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("RoyalFlush - Case 2: Initiated");
                    switch (royalFlushCombo)
                    {
                        case 2:
                            flopCardRoll = (3.0 / 50.0) * (2.0 / 49.0) * (1.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                            Result.RoyalFlush = Math.Round((flopCardRoll * 10) * 100, 1);
                            break;
                        case 1:
                            flopCardRoll = (4.0 / 50.0) * (3.0 / 49.0) * (2.0 / 48.0) * (1.0 / 47.0) * (46.0 / 46.0);
                            Result.RoyalFlush = Math.Round((flopCardRoll * 5) * 100, 1);
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("RoyalFlush - Case 5: Initiated");
                    switch (royalFlushCombo)
                    {
                        case 5:
                            Result.RoyalFlush = 100;
                            break;
                        case 4:
                            turnRoll = (1.0 / 47.0) * (46.0 / 46.0);
                            Result.RoyalFlush = Math.Round((turnRoll * 2) * 100, 1);
                            break;
                        case 3:
                            turnRoll = (2.0 / 47.0) * (1.0 / 46.0);
                            Result.RoyalFlush = Math.Round((turnRoll * 1) * 100, 1);
                            break;
                        default:
                            Result.RoyalFlush = 0;
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine("RoyalFlush - Case 6: Initiated");
                    switch (royalFlushCombo)
                    {
                        case 5:
                            Result.RoyalFlush = 100;
                            break;
                        case 4:
                            riverRoll = (1.0 / 46.0);
                            Result.RoyalFlush = Math.Round((riverRoll * 1) * 100, 1);
                            break;
                        default:
                            Result.RoyalFlush = 0;
                            break;
                    }
                    break;
            }

        }

        public void StraightFlush()
        {
            bool addedCard = false;
            int straightFlushTempCombo = 0;
            int straightFlushMaxCombo = 0;
            List<Card> straightFlushDrawn = new List<Card>();

            for (int i = 1; i < 14; i++)
            {
                for (int j = 0; j < combinationCardCount; j++)
                {
                    if (i == (int)Combination[j].Rank)
                    {
                        straightFlushDrawn.Add(new Card(Combination[j].Suit, Combination[j].Rank, true));
                        addedCard = true;
                        break;
                    }
                    addedCard = false;
                }
                if (addedCard == false)
                {
                    straightFlushDrawn.Add(new Card(Suit.Clubs, (Rank)i, false));
                }
            }

            if (straightFlushDrawn[0].Drawn == true) { straightFlushDrawn.Add(new Card(straightFlushDrawn[0].Suit, straightFlushDrawn[0].Rank, true)); }

            for (int i = 0; i < straightFlushDrawn.Count - 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (straightFlushDrawn[i + j].Drawn == true && straightFlushDrawn[i + j].Suit == straightFlushDrawn[i].Suit)
                    {
                        straightFlushTempCombo++;
                    }
                }
                if (straightFlushTempCombo > straightFlushMaxCombo)
                {
                    straightFlushMaxCombo = straightFlushTempCombo;
                    straightFlushTempCombo = 0;
                }
                else
                {
                    straightFlushTempCombo = 0;
                }
            }

            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("StraightFlush - Case 2: Initiated");
                    switch (straightFlushMaxCombo)
                    {
                        case 2:
                            flopCardRoll = (3.0 / 50.0) * (2.0 / 49.0) * (1.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                            Result.StraightFlush = Math.Round((flopCardRoll * 10) * 100, 1);
                            break;
                        case 1:
                            flopCardRoll = (4.0 / 50.0) * (3.0 / 49.0) * (2.0 / 48.0) * (1.0 / 47.0) * (46.0 / 46.0);
                            Result.StraightFlush = Math.Round((flopCardRoll * 5) * 100, 1);
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("StraightFlush - Case 5: Initiated");
                    switch (straightFlushMaxCombo)
                    {
                        case 5:
                            Result.StraightFlush = 100;
                            break;
                        case 4:
                            turnRoll = (1.0 / 47.0) * (46.0 / 46.0);
                            Result.StraightFlush = Math.Round((turnRoll * 2) * 100, 1);
                            break;
                        case 3:
                            turnRoll = (2.0 / 47.0) * (1.0 / 46.0);
                            Result.StraightFlush = Math.Round((turnRoll * 1) * 100, 1);
                            break;
                        default:
                            Result.StraightFlush = 0;
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine("StraightFlush - Case 6: Initiated");
                    switch (straightFlushMaxCombo)
                    {
                        case 5:
                            Result.StraightFlush = 100;
                            break;
                        case 4:
                            flopCardRoll = (1.0 / 46.0);
                            Result.StraightFlush = Math.Round((flopCardRoll * 1) * 100, 1);
                            break;
                        default:
                            Result.StraightFlush = 0;
                            break;
                    }
                    break;
            }
        }

        public void FourOfAKind()
        {
            // pCard1Match & pCard2Match each player handheld card rank matches with table and eachother
            int pCard1Match = 1;
            int pCard2Match = 1;
            if (Combination[0].Rank == Combination[1].Rank)
            {
                pCard1Match++;
                pCard2Match++;
            }
            // combinationCardCount cards chosen by player - possible values 2(PreFlop), 5(PostFlop), 6(PostTurn)
            switch (combinationCardCount)
            {
                case 2:
                    if (pCard1Match == 2)
                    {
                        flopCardRoll = (2.0 / 50.0) * (1.0 / 49.0) * (48.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                        Result.FourOfAKind = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    else
                    {
                        flopCardRoll = (6.0 / 50.0) * (2.0 / 49.0) * (1.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                        Result.FourOfAKind = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    break;
                case 5:
                    // compare player held card ranks with table card ranks
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            pCard1Match++;
                        }
                        if (Combination[1].Rank == Combination[i].Rank)
                        {
                            pCard2Match++;
                        }
                    }

                    if (pCard1Match > 3 || pCard2Match > 3)
                    {
                        Result.FourOfAKind = 100;
                    }
                    else if (pCard1Match == 3 || pCard2Match == 3)
                    {
                        turnRoll = (1.0 / 47.0) * (46.0 / 46.0);
                        Result.FourOfAKind = Math.Round((turnRoll * 2) * 100, 1);
                    }
                    else if (pCard1Match == 2 || pCard2Match == 2)
                    {
                        turnRoll = (2.0 / 47.0) * (1.0 / 46.0);
                        Result.FourOfAKind = Math.Round((turnRoll * 1) * 100, 1);
                    }
                    else
                    {
                        Result.FourOfAKind = 0;
                    }
                    break;
                case 6:
                    // compare player held card ranks with table card ranks
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            pCard1Match++;
                        }
                        if (Combination[1].Rank == Combination[i].Rank)
                        {
                            pCard2Match++;
                        }
                    }
                    if (pCard1Match > 3 || pCard2Match > 3)
                    {
                        Result.FourOfAKind = 100;
                    }
                    else if (pCard1Match == 3 || pCard2Match == 3)
                    {
                        turnRoll = (1.0 / 46.0);
                        Result.FourOfAKind = Math.Round((turnRoll * 1) * 100, 1);
                    }
                    else
                    {
                        Result.FourOfAKind = 0;
                    }
                    break;
            }
        }

        public void FullHouse()
        {
            int ofRank1 = 0;
            int ofRank2 = 0;
            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("FullHouse - Case 2: Initiated");
                    if (Combination[0].Rank == Combination[1].Rank)
                    {
                        flopCardRoll = (49.0 / 50.0) * (5.0 / 49.0) * (4.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                        Result.FullHouse = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    else
                    {
                        flopCardRoll = (6.0 / 50.0) * (5.0 / 49.0) * (4.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                        Result.FullHouse = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    break;
                case 5:
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            ofRank1++;
                        }
                    }
                    for (int j = 2; j < combinationCardCount; j++)
                    {
                        if (Combination[1].Rank == Combination[j].Rank)
                        {
                            ofRank2++;
                        }
                    }
                    if ((ofRank1 > 1 && ofRank2 > 0) || (ofRank1 > 0 && ofRank2 > 1))
                    {
                        Result.FullHouse = 100;
                    }

                    if (Result.FullHouse != 100 && (ofRank1 > 1 || ofRank2 > 1))
                    {
                        turnRoll = (6.0 / 47.0) * (46.0 / 46.0);
                        Result.FullHouse = Math.Round((turnRoll * 1) * 100, 1);
                    }
                    else if (Result.FullHouse != 100 && (ofRank1 > 0 || ofRank2 > 0))
                    {
                        turnRoll = (9.0 / 47.0) * (2.0 / 46.0);
                        Result.FullHouse = Math.Round((turnRoll * 1) * 100, 1);
                    }
                    else
                    {
                        Result.FullHouse = 0;
                    }

                    break;
                case 6:
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            ofRank1++;
                        }
                    }
                    for (int j = 2; j < combinationCardCount; j++)
                    {
                        if (Combination[1].Rank == Combination[j].Rank)
                        {
                            ofRank2++;
                        }
                    }
                    if ((ofRank1 > 1 && ofRank2 > 0) || (ofRank1 > 0 && ofRank2 > 1))
                    {
                        Result.FullHouse = 100;
                    }

                    if (Result.FullHouse != 100 && (ofRank1 > 1 || ofRank2 > 1))
                    {
                        riverRoll = (9.0 / 46.0);
                        Result.FullHouse = Math.Round((riverRoll * 1) * 100, 1);
                    }
                    else
                    {
                        Result.FullHouse = 0;
                    }
                    break;
            }
        }

        public void Flush()
        {
            int pCard1Suited = 1;
            int pCard2Suited = 1;
            if (Combination[0].Suit == Combination[1].Suit)
            {
                pCard1Suited++;
                pCard2Suited++;
            }
            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("Flush - Case 2: Initiated");
                    if (Combination[0].Suit == Combination[1].Suit)
                    {
                        flopCardRoll = (11.0 / 50.0) * (10.0 / 49.0) * (9.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                        Result.Flush = Math.Round((flopCardRoll * 10) * 100, 1);
                    }
                    else
                    {
                        flopCardRoll = (24.0 / 50.0) * (11.0 / 49.0) * (10.0 / 48.0) * (9.0 / 47.0) * (46.0 / 46.0);
                        Result.Flush = Math.Round((flopCardRoll * 5) * 100, 1);
                    }
                    break;
                case 5:
                    Console.WriteLine("Flush - Case 5: Initiated");
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Suit == Combination[i].Suit)
                        {
                            pCard1Suited++;
                        }
                        if (Combination[1].Suit == Combination[i].Suit)
                        {
                            pCard2Suited++;
                        }
                    }
                    if (pCard1Suited > 4 || pCard2Suited > 4)
                    {
                        Result.Flush = 100;
                    }
                    else if (pCard1Suited == 4 || pCard2Suited == 4)
                    {
                        turnRoll = (9.0 / 47.0) * (46.0 / 46.0);
                        Result.Flush = Math.Round((turnRoll * 2) * 100, 1);
                    }
                    else if (pCard1Suited == 3 || pCard2Suited == 3)
                    {
                        turnRoll = (10.0 / 47.0) * (9.0 / 46.0);
                        Result.Flush = Math.Round((turnRoll * 1) * 100, 1);
                    }
                    else
                    {
                        Result.Flush = 0;
                    }
                    break;
                case 6:
                    Console.WriteLine("Flush - Case 6: Initiated");
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Suit == Combination[i].Suit)
                        {
                            pCard1Suited++;
                        }
                        if (Combination[1].Suit == Combination[i].Suit)
                        {
                            pCard2Suited++;
                        }
                    }
                    if (pCard1Suited > 4 || pCard2Suited > 4)
                    {
                        Result.Flush = 100;
                    }
                    else if (pCard1Suited == 4 || pCard2Suited == 4)
                    {
                        riverRoll = (9.0 / 46.0);
                        Result.Flush = Math.Round((riverRoll * 1) * 100, 1);
                    }
                    else
                    {
                        Result.Flush = 0;
                    }
                    break;
            }
        }

        public void Straight()
        {
            bool addedCard = false;
            int straightTempCombo = 0;
            int straightMaxCombo = 0;
            List<Card> straightDrawn = new List<Card>();

            for (int i = 1; i < 14; i++)
            {
                for (int j = 0; j < combinationCardCount; j++)
                {
                    if (i == (int)Combination[j].Rank)
                    {
                        straightDrawn.Add(new Card(Combination[j].Rank, true));
                        addedCard = true;
                        break;
                    }
                    addedCard = false;
                }
                if (addedCard == false)
                {
                    straightDrawn.Add(new Card((Rank)i, false));
                }
            }

            if (straightDrawn[0].Drawn == true) { straightDrawn.Add(new Card(Rank.Ace, true)); }
            for (int i = 0; i < straightDrawn.Count - 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (straightDrawn[i + j].Drawn == true)
                    {
                        straightTempCombo++;
                    }
                }
                if (straightTempCombo > straightMaxCombo)
                {
                    straightMaxCombo = straightTempCombo;
                    straightTempCombo = 0;
                }
                else
                {
                    straightTempCombo = 0;
                }
            }
            //int something = (int)Combination[0].Rank;
            switch (combinationCardCount)
            {
                case 2:
                    Console.WriteLine("Straight - Case 2: Initiated");
                    switch (straightMaxCombo)
                    {
                        case 2:
                            flopCardRoll = (12.0 / 50.0) * (8.0 / 49.0) * (4.0 / 48.0) * (47.0 / 47.0) * (46.0 / 46.0);
                            Result.Straight = Math.Round((flopCardRoll * 10) * 100, 1);
                            break;
                        case 1:
                            flopCardRoll = (16.0 / 50.0) * (12.0 / 49.0) * (8.0 / 48.0) * (4.0 / 47.0) * (46.0 / 46.0);
                            Result.Straight = Math.Round((flopCardRoll * 5) * 100, 1);
                            break;
                    }
                    break;
                case 5:
                    Console.WriteLine("Straight - Case 5: Initiated");
                    switch (straightMaxCombo)
                    {
                        case 5:
                            Result.Straight = 100;
                            break;
                        case 4:
                            flopCardRoll = (4.0 / 47.0) * (46.0 / 46.0);
                            Result.Straight = Math.Round((flopCardRoll * 2) * 100, 1);
                            break;
                        case 3:
                            flopCardRoll = (8.0 / 47.0) * (4.0 / 46.0);
                            Result.Straight = Math.Round((flopCardRoll * 1) * 100, 1);
                            break;
                        default:
                            Result.Straight = 0;
                            break;
                    }
                    break;
                case 6:
                    Console.WriteLine("Straight - Case 6: Initiated");
                    switch (straightMaxCombo)
                    {
                        case 5:
                            Result.Straight = 100;
                            break;
                        case 4:
                            flopCardRoll = (4.0 / 46.0);
                            Result.Straight = Math.Round((flopCardRoll * 1) * 100, 1);
                            break;
                        default:
                            Result.Straight = 0;
                            break;
                    }
                    break;
            }
        }

        public void ThreeOfAKind()
        {
            int pCard1Match = 1;
            int pCard2Match = 1;
            if (Combination[0].Rank == Combination[1].Rank)
            {
                pCard1Match++;
                pCard2Match++;
            }
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
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            pCard1Match++;
                        }
                        if (Combination[1].Rank == Combination[i].Rank)
                        {
                            pCard2Match++;
                        }
                    }
                    if (pCard1Match > 2 || pCard2Match > 2)
                    {
                        Result.ThreeOfAKind = 100;
                    }
                    else if (pCard1Match == 2 || pCard2Match == 2)
                    {
                        turnRoll = (2.0 / 47.0) * (45.0 / 46.0);
                        Result.ThreeOfAKind = Math.Round((turnRoll * 2) * 100, 1);
                    }
                    else
                    {
                        turnRoll = (6.0 / 47.0) * (2.0 / 46.0);
                        Result.ThreeOfAKind = Math.Round((turnRoll * 2) * 100, 1);
                    }
                    break;
                case 6:
                    Console.WriteLine("ThreeOfAKind - Case 6: Initiated");
                    for (int i = 2; i < combinationCardCount; i++)
                    {
                        if (Combination[0].Rank == Combination[i].Rank)
                        {
                            pCard1Match++;
                        }
                        if (Combination[1].Rank == Combination[i].Rank)
                        {
                            pCard2Match++;
                        }
                    }
                    if (pCard1Match > 2 || pCard2Match > 2)
                    {
                        Result.ThreeOfAKind = 100;
                    }
                    else if (pCard1Match == 2 || pCard2Match == 2)
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
            bool twoPair = false;
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
                                onePair = true;
                            }
                        }
                        for (int j = 2; j < combinationCardCount; j++)
                        {
                            if (Combination[1].Rank == Combination[j].Rank)
                            {
                                twoPair = true;
                            }
                        }
                        if (onePair == true && twoPair == true)
                        {
                            Result.TwoPair = 100;
                        }

                        if (Result.TwoPair != 100 && (onePair == true || twoPair == true))
                        {
                            turnRoll = (45.0 / 47.0) * (3.0 / 46.0);
                            Result.TwoPair = Math.Round((turnRoll * 1) * 100, 1);
                        }
                        else
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
                                onePair = true;
                            }
                        }
                        for (int j = 2; j < combinationCardCount; j++)
                        {
                            if (Combination[1].Rank == Combination[j].Rank)
                            {
                                twoPair = true;
                            }
                        }

                        if (onePair == true && twoPair == true)
                        {
                            Result.TwoPair = 100;
                        }

                        if (Result.TwoPair != 100 && (onePair == true || twoPair == true))
                        {
                            riverRoll = (3.0 / 46.0);
                            Result.TwoPair = Math.Round((riverRoll * 1) * 100, 1);
                        }
                        else
                        {
                            Result.TwoPair = 0;
                        }
                    }
                    break;
            }
        }

        public void OnePair()
        {
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


    }
}
