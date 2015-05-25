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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Play playInput = new Play();
            OddsAndOutsCalculator res = new OddsAndOutsCalculator(playInput);
        }

        private void PlayerCard1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
