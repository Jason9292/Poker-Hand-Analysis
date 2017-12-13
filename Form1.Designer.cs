namespace Poker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.card1Rank = new System.Windows.Forms.TextBox();
            this.card2Rank = new System.Windows.Forms.TextBox();
            this.card3Rank = new System.Windows.Forms.TextBox();
            this.card4Rank = new System.Windows.Forms.TextBox();
            this.card5Rank = new System.Windows.Forms.TextBox();
            this.card1Suit = new System.Windows.Forms.TextBox();
            this.card2Suit = new System.Windows.Forms.TextBox();
            this.card3Suit = new System.Windows.Forms.TextBox();
            this.card4Suit = new System.Windows.Forms.TextBox();
            this.card5Suit = new System.Windows.Forms.TextBox();
            this.displayHand = new System.Windows.Forms.Button();
            this.typeOfHand = new System.Windows.Forms.TextBox();
            this.generateHand = new System.Windows.Forms.Button();
            this.clearHand = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rank:\r\nAce=1, Jack=11,\r\nQueen=12, King=13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Suit:    Diamonds=D,\r\nHearts=H, Clubs=C,\r\nSpades=S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Card #1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Card #2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Card #3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Card #4:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Card #5:";
            // 
            // card1Rank
            // 
            this.card1Rank.Location = new System.Drawing.Point(81, 72);
            this.card1Rank.Name = "card1Rank";
            this.card1Rank.ReadOnly = true;
            this.card1Rank.Size = new System.Drawing.Size(48, 20);
            this.card1Rank.TabIndex = 7;
            // 
            // card2Rank
            // 
            this.card2Rank.Location = new System.Drawing.Point(81, 107);
            this.card2Rank.Name = "card2Rank";
            this.card2Rank.ReadOnly = true;
            this.card2Rank.Size = new System.Drawing.Size(48, 20);
            this.card2Rank.TabIndex = 8;
            // 
            // card3Rank
            // 
            this.card3Rank.Location = new System.Drawing.Point(81, 144);
            this.card3Rank.Name = "card3Rank";
            this.card3Rank.ReadOnly = true;
            this.card3Rank.Size = new System.Drawing.Size(48, 20);
            this.card3Rank.TabIndex = 9;
            // 
            // card4Rank
            // 
            this.card4Rank.Location = new System.Drawing.Point(81, 176);
            this.card4Rank.Name = "card4Rank";
            this.card4Rank.ReadOnly = true;
            this.card4Rank.Size = new System.Drawing.Size(48, 20);
            this.card4Rank.TabIndex = 10;
            // 
            // card5Rank
            // 
            this.card5Rank.Location = new System.Drawing.Point(81, 209);
            this.card5Rank.Name = "card5Rank";
            this.card5Rank.ReadOnly = true;
            this.card5Rank.Size = new System.Drawing.Size(48, 20);
            this.card5Rank.TabIndex = 11;
            // 
            // card1Suit
            // 
            this.card1Suit.Location = new System.Drawing.Point(182, 72);
            this.card1Suit.Name = "card1Suit";
            this.card1Suit.ReadOnly = true;
            this.card1Suit.Size = new System.Drawing.Size(27, 20);
            this.card1Suit.TabIndex = 12;
            // 
            // card2Suit
            // 
            this.card2Suit.Location = new System.Drawing.Point(182, 107);
            this.card2Suit.Name = "card2Suit";
            this.card2Suit.ReadOnly = true;
            this.card2Suit.Size = new System.Drawing.Size(27, 20);
            this.card2Suit.TabIndex = 13;
            // 
            // card3Suit
            // 
            this.card3Suit.Location = new System.Drawing.Point(182, 144);
            this.card3Suit.Name = "card3Suit";
            this.card3Suit.ReadOnly = true;
            this.card3Suit.Size = new System.Drawing.Size(27, 20);
            this.card3Suit.TabIndex = 14;
            // 
            // card4Suit
            // 
            this.card4Suit.Location = new System.Drawing.Point(182, 176);
            this.card4Suit.Name = "card4Suit";
            this.card4Suit.ReadOnly = true;
            this.card4Suit.Size = new System.Drawing.Size(27, 20);
            this.card4Suit.TabIndex = 15;
            // 
            // card5Suit
            // 
            this.card5Suit.Location = new System.Drawing.Point(182, 209);
            this.card5Suit.Name = "card5Suit";
            this.card5Suit.ReadOnly = true;
            this.card5Suit.Size = new System.Drawing.Size(27, 20);
            this.card5Suit.TabIndex = 16;
            // 
            // displayHand
            // 
            this.displayHand.Location = new System.Drawing.Point(30, 282);
            this.displayHand.Name = "displayHand";
            this.displayHand.Size = new System.Drawing.Size(230, 34);
            this.displayHand.TabIndex = 17;
            this.displayHand.Text = "Display Type of Hand";
            this.displayHand.UseVisualStyleBackColor = true;
            this.displayHand.Click += new System.EventHandler(this.displayHand_Click);
            // 
            // typeOfHand
            // 
            this.typeOfHand.Location = new System.Drawing.Point(30, 322);
            this.typeOfHand.Name = "typeOfHand";
            this.typeOfHand.ReadOnly = true;
            this.typeOfHand.Size = new System.Drawing.Size(230, 20);
            this.typeOfHand.TabIndex = 18;
            // 
            // generateHand
            // 
            this.generateHand.Location = new System.Drawing.Point(30, 253);
            this.generateHand.Name = "generateHand";
            this.generateHand.Size = new System.Drawing.Size(122, 23);
            this.generateHand.TabIndex = 19;
            this.generateHand.Text = "Generate New Hand";
            this.generateHand.UseVisualStyleBackColor = true;
            this.generateHand.Click += new System.EventHandler(this.generateHand_Click);
            // 
            // clearHand
            // 
            this.clearHand.Location = new System.Drawing.Point(174, 253);
            this.clearHand.Name = "clearHand";
            this.clearHand.Size = new System.Drawing.Size(86, 23);
            this.clearHand.TabIndex = 20;
            this.clearHand.Text = "Clear Hand";
            this.clearHand.UseVisualStyleBackColor = true;
            this.clearHand.Click += new System.EventHandler(this.clearHand_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(108, 348);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 21;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 385);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clearHand);
            this.Controls.Add(this.generateHand);
            this.Controls.Add(this.typeOfHand);
            this.Controls.Add(this.displayHand);
            this.Controls.Add(this.card5Suit);
            this.Controls.Add(this.card4Suit);
            this.Controls.Add(this.card3Suit);
            this.Controls.Add(this.card2Suit);
            this.Controls.Add(this.card1Suit);
            this.Controls.Add(this.card5Rank);
            this.Controls.Add(this.card4Rank);
            this.Controls.Add(this.card3Rank);
            this.Controls.Add(this.card2Rank);
            this.Controls.Add(this.card1Rank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Poker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox card1Rank;
        private System.Windows.Forms.TextBox card2Rank;
        private System.Windows.Forms.TextBox card3Rank;
        private System.Windows.Forms.TextBox card4Rank;
        private System.Windows.Forms.TextBox card5Rank;
        private System.Windows.Forms.TextBox card1Suit;
        private System.Windows.Forms.TextBox card2Suit;
        private System.Windows.Forms.TextBox card3Suit;
        private System.Windows.Forms.TextBox card4Suit;
        private System.Windows.Forms.TextBox card5Suit;
        private System.Windows.Forms.Button displayHand;
        private System.Windows.Forms.TextBox typeOfHand;
        private System.Windows.Forms.Button generateHand;
        private System.Windows.Forms.Button clearHand;
        private System.Windows.Forms.Button exit;
    }
}

