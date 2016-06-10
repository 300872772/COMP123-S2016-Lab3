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
     * This class create an object that represents a playing card
     * </summary>
     * 
     * @class Card
     */
public class Card
    {
        //PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++++++++++

        public int Face { get; set; }
        public string Suit { get; set; }

        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This constructor has 2 parameters to instantiate Card object
         * </summary>
         * 
         * @constructor Card 
         * @param {int} face
         * @param {string} suit
         * 
         *
         */

        public Card(int face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

    }
}
