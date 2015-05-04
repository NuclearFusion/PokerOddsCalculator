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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card test = new Card(Suit.Spades, Rank.King);

            //button1.Text = test.Suit.ToString() + test.Value.ToString();
            button1.Text = test.Rank.ToString() + " of " + test.Suit.ToString();
            
            Play playInput = new Play();
            OddsAndOutsCalculator res = new OddsAndOutsCalculator(playInput);
        }
    }
}
