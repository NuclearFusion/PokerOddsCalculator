﻿namespace PokerOddsCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.RoyalFlush = new System.Windows.Forms.Label();
            this.StraightFlush = new System.Windows.Forms.Label();
            this.FourOfAKind = new System.Windows.Forms.Label();
            this.FullHouse = new System.Windows.Forms.Label();
            this.Flush = new System.Windows.Forms.Label();
            this.Straight = new System.Windows.Forms.Label();
            this.ThreeOfAKind = new System.Windows.Forms.Label();
            this.TwoPair = new System.Windows.Forms.Label();
            this.OnePair = new System.Windows.Forms.Label();
            this.RoyalFlushOdds = new System.Windows.Forms.Label();
            this.StraightFlushOdds = new System.Windows.Forms.Label();
            this.FourOfAKindOdds = new System.Windows.Forms.Label();
            this.FullHouseOdds = new System.Windows.Forms.Label();
            this.FlushOdds = new System.Windows.Forms.Label();
            this.StraightOdds = new System.Windows.Forms.Label();
            this.ThreeOfAKindOdds = new System.Windows.Forms.Label();
            this.TwoPairOdds = new System.Windows.Forms.Label();
            this.OnePairOdds = new System.Windows.Forms.Label();
            this.PlayerCard1 = new System.Windows.Forms.ComboBox();
            this.PlayerCard2 = new System.Windows.Forms.ComboBox();
            this.FlopCard2 = new System.Windows.Forms.ComboBox();
            this.FlopCard1 = new System.Windows.Forms.ComboBox();
            this.FlopCard3 = new System.Windows.Forms.ComboBox();
            this.TurnCard = new System.Windows.Forms.ComboBox();
            this.RiverCard = new System.Windows.Forms.ComboBox();
            this.playerHand1 = new System.Windows.Forms.Label();
            this.playerHand2 = new System.Windows.Forms.Label();
            this.flopCardLabel1 = new System.Windows.Forms.Label();
            this.flopCardLabel2 = new System.Windows.Forms.Label();
            this.flopCardLabel3 = new System.Windows.Forms.Label();
            this.turnCardLabel = new System.Windows.Forms.Label();
            this.riverCardLabel = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // RoyalFlush
            // 
            this.RoyalFlush.AutoSize = true;
            this.RoyalFlush.Location = new System.Drawing.Point(724, 29);
            this.RoyalFlush.Name = "RoyalFlush";
            this.RoyalFlush.Size = new System.Drawing.Size(62, 13);
            this.RoyalFlush.TabIndex = 1;
            this.RoyalFlush.Text = "Royal Flush";
            // 
            // StraightFlush
            // 
            this.StraightFlush.AutoSize = true;
            this.StraightFlush.Location = new System.Drawing.Point(724, 42);
            this.StraightFlush.Name = "StraightFlush";
            this.StraightFlush.Size = new System.Drawing.Size(71, 13);
            this.StraightFlush.TabIndex = 2;
            this.StraightFlush.Text = "Straight Flush";
            // 
            // FourOfAKind
            // 
            this.FourOfAKind.AutoSize = true;
            this.FourOfAKind.Location = new System.Drawing.Point(724, 55);
            this.FourOfAKind.Name = "FourOfAKind";
            this.FourOfAKind.Size = new System.Drawing.Size(61, 13);
            this.FourOfAKind.TabIndex = 3;
            this.FourOfAKind.Text = "4 Of A Kind";
            // 
            // FullHouse
            // 
            this.FullHouse.AutoSize = true;
            this.FullHouse.Location = new System.Drawing.Point(724, 68);
            this.FullHouse.Name = "FullHouse";
            this.FullHouse.Size = new System.Drawing.Size(57, 13);
            this.FullHouse.TabIndex = 4;
            this.FullHouse.Text = "Full House";
            // 
            // Flush
            // 
            this.Flush.AutoSize = true;
            this.Flush.Location = new System.Drawing.Point(724, 81);
            this.Flush.Name = "Flush";
            this.Flush.Size = new System.Drawing.Size(32, 13);
            this.Flush.TabIndex = 5;
            this.Flush.Text = "Flush";
            // 
            // Straight
            // 
            this.Straight.AutoSize = true;
            this.Straight.Location = new System.Drawing.Point(724, 94);
            this.Straight.Name = "Straight";
            this.Straight.Size = new System.Drawing.Size(43, 13);
            this.Straight.TabIndex = 6;
            this.Straight.Text = "Straight";
            // 
            // ThreeOfAKind
            // 
            this.ThreeOfAKind.AutoSize = true;
            this.ThreeOfAKind.Location = new System.Drawing.Point(724, 107);
            this.ThreeOfAKind.Name = "ThreeOfAKind";
            this.ThreeOfAKind.Size = new System.Drawing.Size(61, 13);
            this.ThreeOfAKind.TabIndex = 7;
            this.ThreeOfAKind.Text = "3 Of A Kind";
            // 
            // TwoPair
            // 
            this.TwoPair.AutoSize = true;
            this.TwoPair.Location = new System.Drawing.Point(724, 120);
            this.TwoPair.Name = "TwoPair";
            this.TwoPair.Size = new System.Drawing.Size(34, 13);
            this.TwoPair.TabIndex = 8;
            this.TwoPair.Text = "2 Pair";
            // 
            // OnePair
            // 
            this.OnePair.AutoSize = true;
            this.OnePair.Location = new System.Drawing.Point(724, 133);
            this.OnePair.Name = "OnePair";
            this.OnePair.Size = new System.Drawing.Size(34, 13);
            this.OnePair.TabIndex = 9;
            this.OnePair.Text = "1 Pair";
            // 
            // RoyalFlushOdds
            // 
            this.RoyalFlushOdds.AutoSize = true;
            this.RoyalFlushOdds.Location = new System.Drawing.Point(697, 29);
            this.RoyalFlushOdds.Name = "RoyalFlushOdds";
            this.RoyalFlushOdds.Size = new System.Drawing.Size(16, 13);
            this.RoyalFlushOdds.TabIndex = 11;
            this.RoyalFlushOdds.Text = "...";
            // 
            // StraightFlushOdds
            // 
            this.StraightFlushOdds.AutoSize = true;
            this.StraightFlushOdds.Location = new System.Drawing.Point(697, 42);
            this.StraightFlushOdds.Name = "StraightFlushOdds";
            this.StraightFlushOdds.Size = new System.Drawing.Size(16, 13);
            this.StraightFlushOdds.TabIndex = 12;
            this.StraightFlushOdds.Text = "...";
            // 
            // FourOfAKindOdds
            // 
            this.FourOfAKindOdds.AutoSize = true;
            this.FourOfAKindOdds.Location = new System.Drawing.Point(697, 55);
            this.FourOfAKindOdds.Name = "FourOfAKindOdds";
            this.FourOfAKindOdds.Size = new System.Drawing.Size(16, 13);
            this.FourOfAKindOdds.TabIndex = 13;
            this.FourOfAKindOdds.Text = "...";
            // 
            // FullHouseOdds
            // 
            this.FullHouseOdds.AutoSize = true;
            this.FullHouseOdds.Location = new System.Drawing.Point(697, 68);
            this.FullHouseOdds.Name = "FullHouseOdds";
            this.FullHouseOdds.Size = new System.Drawing.Size(16, 13);
            this.FullHouseOdds.TabIndex = 14;
            this.FullHouseOdds.Text = "...";
            // 
            // FlushOdds
            // 
            this.FlushOdds.AutoSize = true;
            this.FlushOdds.Location = new System.Drawing.Point(697, 81);
            this.FlushOdds.Name = "FlushOdds";
            this.FlushOdds.Size = new System.Drawing.Size(16, 13);
            this.FlushOdds.TabIndex = 15;
            this.FlushOdds.Text = "...";
            // 
            // StraightOdds
            // 
            this.StraightOdds.AutoSize = true;
            this.StraightOdds.Location = new System.Drawing.Point(697, 94);
            this.StraightOdds.Name = "StraightOdds";
            this.StraightOdds.Size = new System.Drawing.Size(16, 13);
            this.StraightOdds.TabIndex = 16;
            this.StraightOdds.Text = "...";
            // 
            // ThreeOfAKindOdds
            // 
            this.ThreeOfAKindOdds.AutoSize = true;
            this.ThreeOfAKindOdds.Location = new System.Drawing.Point(697, 107);
            this.ThreeOfAKindOdds.Name = "ThreeOfAKindOdds";
            this.ThreeOfAKindOdds.Size = new System.Drawing.Size(16, 13);
            this.ThreeOfAKindOdds.TabIndex = 17;
            this.ThreeOfAKindOdds.Text = "...";
            // 
            // TwoPairOdds
            // 
            this.TwoPairOdds.AutoSize = true;
            this.TwoPairOdds.Location = new System.Drawing.Point(697, 120);
            this.TwoPairOdds.Name = "TwoPairOdds";
            this.TwoPairOdds.Size = new System.Drawing.Size(16, 13);
            this.TwoPairOdds.TabIndex = 18;
            this.TwoPairOdds.Text = "...";
            // 
            // OnePairOdds
            // 
            this.OnePairOdds.AutoSize = true;
            this.OnePairOdds.Location = new System.Drawing.Point(697, 133);
            this.OnePairOdds.Name = "OnePairOdds";
            this.OnePairOdds.Size = new System.Drawing.Size(16, 13);
            this.OnePairOdds.TabIndex = 19;
            this.OnePairOdds.Text = "...";
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.FormattingEnabled = true;
            this.PlayerCard1.Location = new System.Drawing.Point(14, 38);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(108, 21);
            this.PlayerCard1.TabIndex = 20;
            this.PlayerCard1.SelectedIndexChanged += new System.EventHandler(this.PlayerCard1_SelectedIndexChanged);
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.FormattingEnabled = true;
            this.PlayerCard2.Location = new System.Drawing.Point(128, 38);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(108, 21);
            this.PlayerCard2.TabIndex = 21;
            this.PlayerCard2.SelectedIndexChanged += new System.EventHandler(this.PlayerCard2_SelectedIndexChanged);
            // 
            // FlopCard2
            // 
            this.FlopCard2.FormattingEnabled = true;
            this.FlopCard2.Location = new System.Drawing.Point(128, 99);
            this.FlopCard2.Name = "FlopCard2";
            this.FlopCard2.Size = new System.Drawing.Size(108, 21);
            this.FlopCard2.TabIndex = 22;
            this.FlopCard2.SelectedIndexChanged += new System.EventHandler(this.FlopCard2_SelectedIndexChanged);
            // 
            // FlopCard1
            // 
            this.FlopCard1.FormattingEnabled = true;
            this.FlopCard1.Location = new System.Drawing.Point(14, 99);
            this.FlopCard1.Name = "FlopCard1";
            this.FlopCard1.Size = new System.Drawing.Size(108, 21);
            this.FlopCard1.TabIndex = 23;
            this.FlopCard1.SelectedIndexChanged += new System.EventHandler(this.FlopCard1_SelectedIndexChanged);
            // 
            // FlopCard3
            // 
            this.FlopCard3.FormattingEnabled = true;
            this.FlopCard3.Location = new System.Drawing.Point(242, 99);
            this.FlopCard3.Name = "FlopCard3";
            this.FlopCard3.Size = new System.Drawing.Size(108, 21);
            this.FlopCard3.TabIndex = 24;
            this.FlopCard3.SelectedIndexChanged += new System.EventHandler(this.FlopCard3_SelectedIndexChanged);
            // 
            // TurnCard
            // 
            this.TurnCard.FormattingEnabled = true;
            this.TurnCard.Location = new System.Drawing.Point(356, 99);
            this.TurnCard.Name = "TurnCard";
            this.TurnCard.Size = new System.Drawing.Size(108, 21);
            this.TurnCard.TabIndex = 25;
            this.TurnCard.SelectedIndexChanged += new System.EventHandler(this.TurnCard_SelectedIndexChanged);
            // 
            // RiverCard
            // 
            this.RiverCard.FormattingEnabled = true;
            this.RiverCard.Location = new System.Drawing.Point(470, 99);
            this.RiverCard.Name = "RiverCard";
            this.RiverCard.Size = new System.Drawing.Size(108, 21);
            this.RiverCard.TabIndex = 26;
            this.RiverCard.SelectedIndexChanged += new System.EventHandler(this.RiverCard_SelectedIndexChanged);
            // 
            // playerHand1
            // 
            this.playerHand1.AutoSize = true;
            this.playerHand1.Location = new System.Drawing.Point(12, 22);
            this.playerHand1.Name = "playerHand1";
            this.playerHand1.Size = new System.Drawing.Size(70, 13);
            this.playerHand1.TabIndex = 27;
            this.playerHand1.Text = "Player Card 1";
            // 
            // playerHand2
            // 
            this.playerHand2.AutoSize = true;
            this.playerHand2.Location = new System.Drawing.Point(125, 22);
            this.playerHand2.Name = "playerHand2";
            this.playerHand2.Size = new System.Drawing.Size(70, 13);
            this.playerHand2.TabIndex = 28;
            this.playerHand2.Text = "Player Card 2";
            // 
            // flopCardLabel1
            // 
            this.flopCardLabel1.AutoSize = true;
            this.flopCardLabel1.Location = new System.Drawing.Point(12, 81);
            this.flopCardLabel1.Name = "flopCardLabel1";
            this.flopCardLabel1.Size = new System.Drawing.Size(61, 13);
            this.flopCardLabel1.TabIndex = 29;
            this.flopCardLabel1.Text = "Flop Card 1";
            // 
            // flopCardLabel2
            // 
            this.flopCardLabel2.AutoSize = true;
            this.flopCardLabel2.Location = new System.Drawing.Point(125, 81);
            this.flopCardLabel2.Name = "flopCardLabel2";
            this.flopCardLabel2.Size = new System.Drawing.Size(61, 13);
            this.flopCardLabel2.TabIndex = 30;
            this.flopCardLabel2.Text = "Flop Card 2";
            // 
            // flopCardLabel3
            // 
            this.flopCardLabel3.AutoSize = true;
            this.flopCardLabel3.Location = new System.Drawing.Point(239, 81);
            this.flopCardLabel3.Name = "flopCardLabel3";
            this.flopCardLabel3.Size = new System.Drawing.Size(61, 13);
            this.flopCardLabel3.TabIndex = 31;
            this.flopCardLabel3.Text = "Flop Card 3";
            // 
            // turnCardLabel
            // 
            this.turnCardLabel.AutoSize = true;
            this.turnCardLabel.Location = new System.Drawing.Point(353, 81);
            this.turnCardLabel.Name = "turnCardLabel";
            this.turnCardLabel.Size = new System.Drawing.Size(54, 13);
            this.turnCardLabel.TabIndex = 32;
            this.turnCardLabel.Text = "Turn Card";
            // 
            // riverCardLabel
            // 
            this.riverCardLabel.AutoSize = true;
            this.riverCardLabel.Location = new System.Drawing.Point(467, 81);
            this.riverCardLabel.Name = "riverCardLabel";
            this.riverCardLabel.Size = new System.Drawing.Size(57, 13);
            this.riverCardLabel.TabIndex = 33;
            this.riverCardLabel.Text = "River Card";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(125, 230);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(0, 13);
            this.errorText.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 261);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.riverCardLabel);
            this.Controls.Add(this.turnCardLabel);
            this.Controls.Add(this.flopCardLabel3);
            this.Controls.Add(this.flopCardLabel2);
            this.Controls.Add(this.flopCardLabel1);
            this.Controls.Add(this.playerHand2);
            this.Controls.Add(this.playerHand1);
            this.Controls.Add(this.RiverCard);
            this.Controls.Add(this.TurnCard);
            this.Controls.Add(this.FlopCard3);
            this.Controls.Add(this.FlopCard1);
            this.Controls.Add(this.FlopCard2);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.OnePairOdds);
            this.Controls.Add(this.TwoPairOdds);
            this.Controls.Add(this.ThreeOfAKindOdds);
            this.Controls.Add(this.StraightOdds);
            this.Controls.Add(this.FlushOdds);
            this.Controls.Add(this.FullHouseOdds);
            this.Controls.Add(this.FourOfAKindOdds);
            this.Controls.Add(this.StraightFlushOdds);
            this.Controls.Add(this.RoyalFlushOdds);
            this.Controls.Add(this.OnePair);
            this.Controls.Add(this.TwoPair);
            this.Controls.Add(this.ThreeOfAKind);
            this.Controls.Add(this.Straight);
            this.Controls.Add(this.Flush);
            this.Controls.Add(this.FullHouse);
            this.Controls.Add(this.FourOfAKind);
            this.Controls.Add(this.StraightFlush);
            this.Controls.Add(this.RoyalFlush);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Poker Odds Calcuator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label RoyalFlush;
        private System.Windows.Forms.Label StraightFlush;
        private System.Windows.Forms.Label FourOfAKind;
        private System.Windows.Forms.Label FullHouse;
        private System.Windows.Forms.Label Flush;
        private System.Windows.Forms.Label Straight;
        private System.Windows.Forms.Label ThreeOfAKind;
        private System.Windows.Forms.Label TwoPair;
        private System.Windows.Forms.Label OnePair;
        private System.Windows.Forms.Label RoyalFlushOdds;
        private System.Windows.Forms.Label StraightFlushOdds;
        private System.Windows.Forms.Label FourOfAKindOdds;
        private System.Windows.Forms.Label FullHouseOdds;
        private System.Windows.Forms.Label FlushOdds;
        private System.Windows.Forms.Label StraightOdds;
        private System.Windows.Forms.Label ThreeOfAKindOdds;
        private System.Windows.Forms.Label TwoPairOdds;
        private System.Windows.Forms.Label OnePairOdds;
        private System.Windows.Forms.ComboBox PlayerCard1;
        private System.Windows.Forms.ComboBox PlayerCard2;
        private System.Windows.Forms.ComboBox FlopCard2;
        private System.Windows.Forms.ComboBox FlopCard1;
        private System.Windows.Forms.ComboBox FlopCard3;
        private System.Windows.Forms.ComboBox TurnCard;
        private System.Windows.Forms.ComboBox RiverCard;
        private System.Windows.Forms.Label playerHand1;
        private System.Windows.Forms.Label playerHand2;
        private System.Windows.Forms.Label flopCardLabel1;
        private System.Windows.Forms.Label flopCardLabel2;
        private System.Windows.Forms.Label flopCardLabel3;
        private System.Windows.Forms.Label turnCardLabel;
        private System.Windows.Forms.Label riverCardLabel;
        private System.Windows.Forms.Label errorText;
    }
}

