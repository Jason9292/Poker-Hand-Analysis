using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] hand = new int[4, 13];             //create 2D array for deck of cards
        int cardOne = 0;
        int cardTwo = 0;                          //place holders, set to -1 if part of 3 of a kind
        int cardThree = 0;                        //so it isn't read as a pair too if already 3 of a kind
        int cardFour = 0;
        int cardFive = 0;

        private void displayHand_Click(object sender, EventArgs e)
        {
            if (straightFlush() == true)                        //check hands in order of how good they are
            {
                typeOfHand.Text = "The hand is a straight flush.";
            }

            else if (fourOfAKind() == true)
            {
                typeOfHand.Text = "The hand is a four of a kind.";
            }

            else if (fullHouse() == true)
            {
                typeOfHand.Text = "The hand is a full house.";
            }

            else if (flush() == true)
            {
                typeOfHand.Text = "The hand is a flush.";
            }

            else if (straight() == true)
            {
                typeOfHand.Text = "The hand is a straight.";
            }

            else if (threeOfAKind() == true)
            {
                typeOfHand.Text = "The hand is a three of a kind.";
            }

            else if (twoPair() == true)
            {
                typeOfHand.Text = "The hand is a two pair";
            }

            else if (onePair() == true)
            {
                typeOfHand.Text = "The hand is a pair.";
            }

            else
            {
                typeOfHand.Text = "The hand didn't get anything.";
            }
        }

        private Boolean flush()                  //function to determine if hand is a flush
        {
            if ((card1Suit.Text.Equals(card2Suit.Text)) && (card1Suit.Text.Equals(card3Suit.Text)) && (card1Suit.Text.Equals(card4Suit.Text)) && (card1Suit.Text.Equals(card5Suit.Text)))
            {
                return true;
            }

            return false;                       //return true if all cards have same suit
        }

        private Boolean straight()              //function to determine if hand is a straight
        {
            int[] inOrder = {Convert.ToInt16(card1Rank.Text), Convert.ToInt16(card2Rank.Text), Convert.ToInt16(card3Rank.Text), Convert.ToInt16(card4Rank.Text), Convert.ToInt16(card5Rank.Text) };         //array to hold sorted hand

            int i, j;
            int n = 5;
            int temp;

            for (j = 0; j < n - 1; j++)              //use selection sort to sort the hand
            {
                int iMin = j;

                for (i = j + 1; i < n; i++)
                {
                    if (inOrder[i] < inOrder[iMin])
                    {
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    temp = inOrder[iMin];
                    inOrder[iMin] = inOrder[j];
                    inOrder[j] = temp;
                }
            }

            if ((inOrder[1] - inOrder[0] == 1) && (inOrder[2] - inOrder[1] == 1) && (inOrder[3] - inOrder[2] == 1) && (inOrder[4] - inOrder[3] == 1) && (inOrder[5] - inOrder[4] == 1)){
                return true;
            }

            return false;           //return true if each card is exactly one position higher than the card before it

        }

        private Boolean straightFlush()         //return true if both straight and flush
        {
            if ((flush() == true) && (straight() == true))
            {
                return true;
            }

            return false;
        }

        private Boolean fourOfAKind()
        {
           
            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card2Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card3Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card4Rank.Text)))
            {
                return true;        //cards 1,2,3,4 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card2Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card3Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card5Rank.Text)))
            {
                return true;        //cards 1,2,3,5 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card5Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card3Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card4Rank.Text)))
            {
                return true;        //cards 1,3,4,5 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card2Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card5Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card4Rank.Text)))
            {
                return true;        //cards 1,2,4,5 are the same
            }

            if ((Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card3Rank.Text)) && (Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card4Rank.Text)) && (Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card5Rank.Text)))
            {
                return true;        //cards 2,3,4,5 are the same
            }

            return false;
        }

        private Boolean threeOfAKind()
        {
            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card2Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card3Rank.Text)))
            {
                cardOne = -1;               //set these cards equal to -1
                cardTwo = -1;               //so when checking if pair or not the same 3 of a kind isn't reported as a pair too
                cardThree = -1;
                return true;        //cards 1,2,3 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card2Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card4Rank.Text)))
            {
                cardOne = -1;
                cardTwo = -1;
                cardFour = -1;
                return true;        //cards 1,2,4 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card2Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card5Rank.Text)))
            {
                cardOne = -1;
                cardTwo = -1;
                cardFive = -1;
                return true;        //cards 1,2,5 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card4Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card3Rank.Text)))
            {
                cardOne = -1;
                cardThree = -1;
                cardFour = -1;
                return true;        //cards 1,3,4 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card5Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card3Rank.Text)))
            {
                cardOne = -1;
                cardFive = -1;
                cardThree = -1;
                return true;        //cards 1,3,5 are the same
            }

            if ((Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card4Rank.Text)) && (Convert.ToInt16(card1Rank.Text) == Convert.ToInt16(card5Rank.Text)))
            {
                cardOne = -1;
                cardFour = -1;
                cardFive = -1;
                return true;        //cards 1,4,5 are the same
            }

            if ((Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card3Rank.Text)) && (Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card4Rank.Text)))
            {
                cardFour = -1;
                cardTwo = -1;
                cardThree = -1;
                return true;        //cards 2,3,4 are the same
            }

            if ((Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card3Rank.Text)) && (Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card5Rank.Text)))
            {
                cardFive = -1;
                cardTwo = -1;
                cardThree = -1;
                return true;        //cards 2,3,5 are the same
            }

            if ((Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card5Rank.Text)) && (Convert.ToInt16(card2Rank.Text) == Convert.ToInt16(card4Rank.Text)))
            {
                cardFour = -1;
                cardTwo = -1;
                cardFive = -1;
                return true;        //cards 2,4,5 are the same
            }

            if ((Convert.ToInt16(card3Rank.Text) == Convert.ToInt16(card4Rank.Text)) && (Convert.ToInt16(card3Rank.Text) == Convert.ToInt16(card5Rank.Text)))
            {
                cardFour = -1;
                cardFive = -1;
                cardThree = -1;
                return true;        //cards 3,4,5 are the same
            }

            return false;
        }

        private Boolean onePair()           //determine if there is a pair in the function
        {
            int[] handPair = { Convert.ToInt16(card1Rank.Text), Convert.ToInt16(card2Rank.Text), Convert.ToInt16(card3Rank.Text), Convert.ToInt16(card4Rank.Text), Convert.ToInt16(card5Rank.Text) };
            
            for (int i = 1; i < 5; i++)
            {
                if ((handPair[0] == handPair[i]) && (cardOne != -1))     //check that card hasn't been set equal to -1
                {
                    return true;                    //if card1 is equal to any of the others
                }
            }

            for (int i = 2; i < 5; i++)
            {
                if ((handPair[1] == handPair[i]) && (cardTwo != -1))     //check that card hasn't been set equal to -1
                {
                    return true;                    //if card2 is equal to card3,4,or 5
                }
            }

            for (int i = 3; i < 5; i++)
            {
                if ((handPair[2] == handPair[i]) && (cardThree != -1)){      //check that card hasn't been set equal to -1
                    return true;                    //if card3 is equal to card4 or 5
                }
            }

            if ((handPair[3] == handPair[4]) && (cardFour != -1))
            {
                return true;                        //if card 4 is equal to card5
            }

            return false;
        }

        private Boolean fullHouse()
        {
            if ((onePair() == true) && (threeOfAKind() == true))
            {
                return true;                                //full house if one pair and three of a kind
            }

            return false;
        }

        private Boolean twoPair()
        {
            int[] handPair = { Convert.ToInt16(card1Rank.Text), Convert.ToInt16(card2Rank.Text), Convert.ToInt16(card3Rank.Text), Convert.ToInt16(card4Rank.Text), Convert.ToInt16(card5Rank.Text) };
            int pairNumber = 0;
            int pastPair = -1;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if ((handPair[i] == handPair[j]) && (handPair[i] != pastPair))         //if any card is equal to another card there is a pair
                    {
                        pairNumber++;                       //keep track of how many pairs
                        pastPair = handPair[i];             //make sure three of a kind isn't mistaken as two pair
                        continue;
                    }
                }
            }

            return false;
        }

        private void generateHand_Click(object sender, EventArgs e)
        {
            Random randSuit = new Random();       //create random object to choose the suit
            Random randRank = new Random();       //create random object to choose rank

            int suit;
            int rank;

            for (int i = 0; i < 5; i++)           //iterate 5 times to generate 5 cards
            {
                do                                //create new hand
                {
                    suit = randSuit.Next(4);      //random number between 0 and 3
                    rank = randRank.Next(13);     //random number between 0 and 12
                    if (hand[suit,rank] == 0)
                    {
                        break;                    //break out of do while if new card
                    }
                } while (hand[suit, rank] != 1);  //while card hasn't already been pulled

                hand[suit, rank] = 1;             //if card was available add to hand
            }

            card1();                              //call function to generate card1
            card2();                              //call function to generate card2
            card3();                              //call function to generate card3
            card4();                              //call function to generate card4
            card5();                              //call function to generate card5
        }

        private void card1()      //function to print card1
        {
            int rank = 0;
            int suit = 0;

            for (int i = 0; i < 4; i++)           //iterate 4 times for each suit
            {
                for (int j = 0; j < 13; j++)      //iterate 13 times for each rank
                {
                    if (hand[i, j] == 1)
                    {
                        suit = i;
                        rank = j;
                        hand[i, j] = 0;          //make sure this card isn't read for next card in hand
                        i = 4;                   //make sure outer loop stops iterating
                        break;                   //break inner loop
                    }
                }
            }

           switch (suit)                         //switch statement to identify which suit the card is
            {
                case 0:
                    card1Suit.Text = "C";
                    break;
                case 1:
                    card1Suit.Text = "D";
                    break;
                case 2:
                    card1Suit.Text = "H";
                    break;
                default:
                    card1Suit.Text = "S";
                    break;
            }
            switch (rank)                       //switch statement to identify which rank the card is
            {
                case 0:
                    card1Rank.Text = "1";
                    break;
                case 1:
                    card1Rank.Text = "2";
                    break;
                case 2:
                    card1Rank.Text = "3";
                    break;
                case 3:
                    card1Rank.Text = "4";
                    break;
                case 4:
                    card1Rank.Text = "5";
                    break;
                case 5:
                    card1Rank.Text = "6";
                    break;
                case 6:
                    card1Rank.Text = "7";
                    break;
                case 7:
                    card1Rank.Text = "8";
                    break;
                case 8:
                    card1Rank.Text = "9";
                    break;
                case 9:
                    card1Rank.Text = "10";
                    break;
                case 10:
                    card1Rank.Text = "11";
                    break;
                case 11:
                    card1Rank.Text = "12";
                    break;
                default:
                    card1Rank.Text = "13";
                    break;
            }
        }

        private void card2()      //function to print card2
        {
            int rank = 0;
            int suit = 0;

            for (int i = 0; i < 4; i++)           //iterate 4 times for each suit
            {
                for (int j = 0; j < 13; j++)      //iterate 13 times for each rank
                {
                    if (hand[i, j] == 1)
                    {
                        suit = i;
                        rank = j;
                        hand[i, j] = 0;          //make sure this card isn't read for next card in hand
                        i = 4;                   //make sure outer loop stops iterating
                        break;                   //break inner loop
                    }
                }
            }

            switch (suit)                         //switch statement to identify which suit the card is
            {
                case 0:
                    card2Suit.Text = "C";
                    break;
                case 1:
                    card2Suit.Text = "D";
                    break;
                case 2:
                    card2Suit.Text = "H";
                    break;
                default:
                    card2Suit.Text = "S";
                    break;
            }
            switch (rank)                       //switch statement to identify which rank the card is
            {
                case 0:
                    card2Rank.Text = "1";
                    break;
                case 1:
                    card2Rank.Text = "2";
                    break;
                case 2:
                    card2Rank.Text = "3";
                    break;
                case 3:
                    card2Rank.Text = "4";
                    break;
                case 4:
                    card2Rank.Text = "5";
                    break;
                case 5:
                    card2Rank.Text = "6";
                    break;
                case 6:
                    card2Rank.Text = "7";
                    break;
                case 7:
                    card2Rank.Text = "8";
                    break;
                case 8:
                    card2Rank.Text = "9";
                    break;
                case 9:
                    card2Rank.Text = "10";
                    break;
                case 10:
                    card2Rank.Text = "11";
                    break;
                case 11:
                    card2Rank.Text = "12";
                    break;
                default:
                    card2Rank.Text = "13";
                    break;
            }
        }

        private void card3()      //function to print card3
        {
            int rank = 0;
            int suit = 0;

            for (int i = 0; i < 4; i++)           //iterate 4 times for each suit
            {
                for (int j = 0; j < 13; j++)      //iterate 13 times for each rank
                {
                    if (hand[i, j] == 1)
                    {
                        suit = i;
                        rank = j;
                        hand[i, j] = 0;          //make sure this card isn't read for next card in hand
                        i = 4;                   //make sure outer loop stops iterating
                        break;                   //break inner loop
                    }
                }
            }

            switch (suit)                         //switch statement to identify which suit the card is
            {
                case 0:
                    card3Suit.Text = "C";
                    break;
                case 1:
                    card3Suit.Text = "D";
                    break;
                case 2:
                    card3Suit.Text = "H";
                    break;
                default:
                    card3Suit.Text = "S";
                    break;
            }
            switch (rank)                       //switch statement to identify which rank the card is
            {
                case 0:
                    card3Rank.Text = "1";
                    break;
                case 1:
                    card3Rank.Text = "2";
                    break;
                case 2:
                    card3Rank.Text = "3";
                    break;
                case 3:
                    card3Rank.Text = "4";
                    break;
                case 4:
                    card3Rank.Text = "5";
                    break;
                case 5:
                    card3Rank.Text = "6";
                    break;
                case 6:
                    card3Rank.Text = "7";
                    break;
                case 7:
                    card3Rank.Text = "8";
                    break;
                case 8:
                    card3Rank.Text = "9";
                    break;
                case 9:
                    card3Rank.Text = "10";
                    break;
                case 10:
                    card3Rank.Text = "11";
                    break;
                case 11:
                    card3Rank.Text = "12";
                    break;
                default:
                    card3Rank.Text = "13";
                    break;
            }
        }

        private void card4()                     //function to print card4
        {
            int rank = 0;
            int suit = 0;

            for (int i = 0; i < 4; i++)           //iterate 4 times for each suit
            {
                for (int j = 0; j < 13; j++)      //iterate 13 times for each rank
                {
                    if (hand[i, j] == 1)
                    {
                        suit = i;
                        rank = j;
                        hand[i, j] = 0;          //make sure this card isn't read for next card in hand
                        i = 4;                   //make sure outer loop stops iterating
                        break;                   //break inner loop
                    }
                }
            }

            switch (suit)                         //switch statement to identify which suit the card is
            {
                case 0:
                    card4Suit.Text = "C";
                    break;
                case 1:
                    card4Suit.Text = "D";
                    break;
                case 2:
                    card4Suit.Text = "H";
                    break;
                default:
                    card4Suit.Text = "S";
                    break;
            }
            switch (rank)                       //switch statement to identify which rank the card is
            {
                case 0:
                    card4Rank.Text = "1";
                    break;
                case 1:
                    card4Rank.Text = "2";
                    break;
                case 2:
                    card4Rank.Text = "3";
                    break;
                case 3:
                    card4Rank.Text = "4";
                    break;
                case 4:
                    card4Rank.Text = "5";
                    break;
                case 5:
                    card4Rank.Text = "6";
                    break;
                case 6:
                    card4Rank.Text = "7";
                    break;
                case 7:
                    card4Rank.Text = "8";
                    break;
                case 8:
                    card4Rank.Text = "9";
                    break;
                case 9:
                    card4Rank.Text = "10";
                    break;
                case 10:
                    card4Rank.Text = "11";
                    break;
                case 11:
                    card4Rank.Text = "12";
                    break;
                default:
                    card4Rank.Text = "13";
                    break;
            }
        }

        private void card5()                      //function to print card5
        {
            int rank = 0;
            int suit = 0;

            for (int i = 0; i < 4; i++)           //iterate 4 times for each suit
            {
                for (int j = 0; j < 13; j++)      //iterate 13 times for each rank
                {
                    if (hand[i, j] == 1)
                    {
                        suit = i;
                        rank = j;
                        hand[i, j] = 0;          //make sure this card isn't read for next card in hand
                        i = 4;                   //make sure outer loop stops iterating
                        break;                   //break inner loop
                    }
                }
            }

            switch (suit)                         //switch statement to identify which suit the card is
            {
                case 0:
                    card5Suit.Text = "C";
                    break;
                case 1:
                    card5Suit.Text = "D";
                    break;
                case 2:
                    card5Suit.Text = "H";
                    break;
                default:
                    card5Suit.Text = "S";
                    break;
            }
            switch (rank)                       //switch statement to identify which rank the card is
            {
                case 0:
                    card5Rank.Text = "1";
                    break;
                case 1:
                    card5Rank.Text = "2";
                    break;
                case 2:
                    card5Rank.Text = "3";
                    break;
                case 3:
                    card5Rank.Text = "4";
                    break;
                case 4:
                    card5Rank.Text = "5";
                    break;
                case 5:
                    card5Rank.Text = "6";
                    break;
                case 6:
                    card5Rank.Text = "7";
                    break;
                case 7:
                    card5Rank.Text = "8";
                    break;
                case 8:
                    card5Rank.Text = "9";
                    break;
                case 9:
                    card5Rank.Text = "10";
                    break;
                case 10:
                    card5Rank.Text = "11";
                    break;
                case 11:
                    card5Rank.Text = "12";
                    break;
                default:
                    card5Rank.Text = "13";
                    break;
            }
        }

        private void clearHand_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    hand[i, j] = 0;                 //put every card back into the deck
                }
            }

            typeOfHand.Text = "";

            card1Rank.Text = "";
            card2Rank.Text = "";
            card3Rank.Text = "";
            card4Rank.Text = "";
            card5Rank.Text = "";

            card1Suit.Text = "";
            card2Suit.Text = "";
            card3Suit.Text = "";
            card4Suit.Text = "";
            card5Suit.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();                       //close the application
        }
    }
}
