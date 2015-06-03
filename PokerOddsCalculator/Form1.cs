using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerOddsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            PlayerCard1.Items.Add("");
            PlayerCard2.Items.Add("");
            FlopCard1.Items.Add("");
            FlopCard2.Items.Add("");
            FlopCard3.Items.Add("");
            TurnCard.Items.Add("");
            RiverCard.Items.Add("");
            for (int i = 0; i < 52 ; i++)
            {
                int suit = i/13+1;
                int rank = i%13+1;
                Card card = new Card((Suit)suit, (Rank)rank);
                PlayerCard1.Items.Add(card.ToString());
                PlayerCard2.Items.Add(card.ToString());
                FlopCard1.Items.Add(card.ToString());
                FlopCard2.Items.Add(card.ToString());
                FlopCard3.Items.Add(card.ToString());
                TurnCard.Items.Add(card.ToString());
                RiverCard.Items.Add(card.ToString());
            }
            RiverCard.Enabled = false;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            bool error = false;
            errorText.Text = "";
            PlayerHand pHand = new PlayerHand();
            Table table = new Table();
            Play play = new Play();
            if (!String.IsNullOrEmpty(PlayerCard1.Text) && !String.IsNullOrEmpty(PlayerCard2.Text))
            {
                pHand.PlayerCard1 = new Card(Card.TextToSuit(PlayerCard1.Text), Card.TextToRank(PlayerCard1.Text));
                pHand.PlayerCard2 = new Card(Card.TextToSuit(PlayerCard2.Text), Card.TextToRank(PlayerCard2.Text));
                if (!String.IsNullOrEmpty(FlopCard1.Text) && !String.IsNullOrEmpty(FlopCard2.Text) && !String.IsNullOrEmpty(FlopCard3.Text))
                {
                    table.Flop1 = new Card(Card.TextToSuit(FlopCard1.Text), Card.TextToRank(FlopCard1.Text));
                    table.Flop2 = new Card(Card.TextToSuit(FlopCard2.Text), Card.TextToRank(FlopCard2.Text));
                    table.Flop3 = new Card(Card.TextToSuit(FlopCard3.Text), Card.TextToRank(FlopCard3.Text));
                    if (!String.IsNullOrEmpty(TurnCard.Text))
                    {
                        table.Turn = new Card(Card.TextToSuit(TurnCard.Text), Card.TextToRank(TurnCard.Text));
                        if (!String.IsNullOrEmpty(RiverCard.Text))
                        {
                            table.River = new Card(Card.TextToSuit(RiverCard.Text), Card.TextToRank(RiverCard.Text));
                            if (!String.IsNullOrEmpty(FlopCard1.Text) || !String.IsNullOrEmpty(FlopCard2.Text) || !String.IsNullOrEmpty(FlopCard3.Text))
                {
                    error = true;
                    errorText.Text = "Izvēlieties: ";
                    if (String.IsNullOrEmpty(FlopCard1.Text))
                    {
                        errorText.Text = errorText.Text + flopCardLabel1.Text;
                        if (String.IsNullOrEmpty(FlopCard2.Text))
                        {
                            errorText.Text = errorText.Text + ", " + flopCardLabel2.Text;
                        }
                        if (String.IsNullOrEmpty(FlopCard3.Text))
                        {
                            errorText.Text = errorText.Text + ", " + flopCardLabel3.Text;
                        }
                    }
                    else if (String.IsNullOrEmpty(FlopCard2.Text))
                    {
                        errorText.Text = errorText.Text + flopCardLabel2.Text;
                        if (String.IsNullOrEmpty(FlopCard3.Text))
                        {
                            errorText.Text = errorText.Text + ", " + flopCardLabel3.Text;
                        }
                    }
                    else if (String.IsNullOrEmpty(FlopCard3.Text))
                    {
                        errorText.Text = errorText.Text + flopCardLabel3.Text;
                    }
                }
                        }
                        else
                        {
                            table.River = null;
                        }
                    }
                    else
                    {
                        table.Turn = null;
                    }
                }
                else if (!String.IsNullOrEmpty(FlopCard1.Text) || !String.IsNullOrEmpty(FlopCard2.Text) || !String.IsNullOrEmpty(FlopCard3.Text) || !String.IsNullOrEmpty(TurnCard.Text))
                {
                    error = true;
                    errorText.Text = "Izvēlieties: ";
                    if (String.IsNullOrEmpty(FlopCard1.Text))
                    {
                        errorText.Text = errorText.Text + flopCardLabel1.Text;
                        if (String.IsNullOrEmpty(FlopCard2.Text))
                        {
                            errorText.Text = errorText.Text + ", " + flopCardLabel2.Text;
                        }
                        if (String.IsNullOrEmpty(FlopCard3.Text))
                        {
                            errorText.Text = errorText.Text + ", " + flopCardLabel3.Text;
                        }
                    }
                    else if (String.IsNullOrEmpty(FlopCard2.Text))
                    {
                        errorText.Text = errorText.Text + flopCardLabel2.Text;
                        if (String.IsNullOrEmpty(FlopCard3.Text))
                        {
                            errorText.Text = errorText.Text + ", " + flopCardLabel3.Text;
                        }
                    }
                    else if (String.IsNullOrEmpty(FlopCard3.Text))
                    {
                        errorText.Text = errorText.Text + flopCardLabel3.Text;
                    }
                }
                else
                {
                    table.Flop1 = null;
                    table.Flop2 = null;
                    table.Flop3 = null;
                }
            }
            else
            {
                error = true;
                errorText.Text = "Izvēlieties: ";
                if(String.IsNullOrEmpty(PlayerCard1.Text))
                {
                    errorText.Text = errorText.Text + playerHand1.Text;
                    if (String.IsNullOrEmpty(PlayerCard2.Text))
                    {
                        errorText.Text = errorText.Text + ", " + playerHand2.Text;
                    }
                }
                else if (String.IsNullOrEmpty(PlayerCard2.Text))
                {
                    errorText.Text = errorText.Text + playerHand2.Text;
                }
            }

            play.PlayerHand = pHand;
            play.Table = table;
            if (error == false)
            {
                OddsAndOutsCalculator res = new OddsAndOutsCalculator(play);
                OddsAndOutsResult result = res.getResult();
                OnePairOdds.Text = result.OnePair.ToString();
                TwoPairOdds.Text = result.TwoPair.ToString();
                ThreeOfAKindOdds.Text = result.ThreeOfAKind.ToString();
                StraightOdds.Text = result.Straight.ToString();
                FlushOdds.Text = result.Flush.ToString();
                FullHouseOdds.Text = result.FullHouse.ToString();
                FourOfAKindOdds.Text = result.FourOfAKind.ToString();
                StraightFlushOdds.Text = result.StraightFlush.ToString();
                RoyalFlushOdds.Text = result.RoyalFlush.ToString();
            }
        }

        private void PlayerCard1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlayerCard2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlopCard1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlopCard2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlopCard3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TurnCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RiverCard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
