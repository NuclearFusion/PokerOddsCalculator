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

        public OddsAndOutsCalculator(Play playInput)
        {
            Play = playInput;
        }

        public void RoyalFlush()
        {

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

        }

        public struct OddsAndOutsResult
        {
            decimal RoyalFlush;
            decimal StraightFlush;
            decimal FourOfAKind;
            decimal FullHouse;
            decimal Flush;
            decimal Straight;
            decimal ThreeOfAKind;
            decimal TwoPair;
            decimal OnePair;
        }
    }
}
