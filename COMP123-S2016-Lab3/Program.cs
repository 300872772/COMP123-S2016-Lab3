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
* 
* 
* Version: 0.0.2 - Added method in driver class.
*/

namespace COMP123_S2016_Lab3
{
    /**
    * This class is the "driver" class for our Program
    * 
    * @class Program
    */
    public class Program
    {
        /**
        * the main method for our driver class Program
        * 
        * @method Main
        * @param {sting[]} args
        * @returns {void}
        */

        static void Main(string[] args)
        {
            Deck deck = new Deck(); // create a deck of cards 
            deck.Display(); // display the initial state of the deck 



            deck.Shuffle(); // shuffle the deck 
            deck.Display(); // display the deck after shuffling 



            Card cardDealt = deck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDealt.Face, cardDealt.Suit);
            Console.WriteLine();
            deck.Display();


            Console.ReadKey();
        }
    }
}
