using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*Author: Md Mamunur Rahman
* Student ID: 300872772 
*
* Date: June 06, 2016
* Description: This program demonstrates Playing card game. 
*/
namespace COMP123_S2016_Lab3
{
    
    /**
    * <summary>
    * This class extends the List<Card> generic type
    * </summary>
    * 
    * @class Deck
    */

public class Deck : List<Card>
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the default constructor for the Deck class
        * </summary>
        * 
        * @constructor Deck
        */
        public Deck()
        {
            this._create();
        }


        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This method loads a list of cards with Card objects
        * </summary>
        * 
        * @private
        * @method _create
        * @returns {void}
        */
        private void _create()
        {
            string suit = "";

            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {

                switch (suitIndex)
                {
                    case 0:
                        suit = "Hearts";
                        break;
                    case 1:
                        suit = "Clubs";
                        break;
                    case 2:
                        suit = "Diamonds";
                        break;
                    case 3:
                        suit = "Spades";
                        break;

                }

                for (int face = 1; face < 14; face++)
                {
                    this.Add(new Card(face, suit));
                }

            }
        }//end _create method


        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This method displays a List of Card objects to the Console
        * </summary>
        * 
        * @method Display
        * @returns {void}
        */
        public void Display()
        {
            string[,] data = new string[13, 4];
            int row = 0;
            int col = 0;
            int deckIndex = 1;
            string deckIndexSpace = "";
            string faceSpace = "";
            string suitSpace = "";

            //insert card data into 2 dimentional array
            foreach (Card card in this)
            {

                if (row > 12) { row = 0; col++; }

                // Console.WriteLine("{0} {1}" ,card.Suit,card.Face );

                if (deckIndex < 10)
                {
                    deckIndexSpace = "  ";
                }
                else
                {
                    deckIndexSpace = " ";
                }
                if (card.Face < 10)
                {
                    faceSpace = "  ";
                }
                else
                {
                    faceSpace = " ";
                }
                switch (card.Suit)
                {
                    case "Hearts":
                        suitSpace = "   ";
                        break;
                    case "Clubs":
                        suitSpace = "    ";
                        break;
                    case "Diamonds":
                        suitSpace = " ";
                        break;
                    case "Spades":
                        suitSpace = "   ";
                        break;

                }

                data[row, col] = deckIndex + deckIndexSpace + card.Suit + suitSpace + card.Face + faceSpace;
                row++;
                deckIndex++;
            }


            //show card data to console 
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+                          Current Deck                            +");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();



            for (int rowindex = 0; rowindex < 13; rowindex++)
            {
                for (int colindex = 0; colindex < 4; colindex++)
                {


                    Console.Write("{0}{1}|", data[rowindex, colindex].ToString(), faceSpace);


                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine();

        }//end Display method

        /**
        * <summary>
        * This method randomly shuffles a List of Card objects
        * </summary>
        * 
        * @method Shuffle
        * @returns {void}
        */

        public void Shuffle()
        {

            Random random = new Random();

            int cardCount = this.Count;

            //shuffle looping
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard];
                int randomCard = random.Next(0, cardCount);
                this[currentCard] = this[randomCard];
                this[randomCard] = tempCard;
            }

        }

        /**
        * <summary>
        * This method will remove the 0th item from the deck and return it to the caller
        * </summary>
        * 
        * @method Deal
        * @returns {Card}
        */

        public Card Deal()
        {
            Card returnedCard = this[0];
             
            // check to see if the deck is not empty
            if (this.Count>0)
            {
                this.RemoveAt(0);
            }
            return returnedCard;
        }

    }//end class
}//end namaspace
