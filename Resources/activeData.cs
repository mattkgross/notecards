using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resources
{
    /* activeData stores and manages the data for the current card being read
     * and/or edited.  Each card is implemented using an activeData object, and
     * the complete cardfile data is stored in a list of activeData objects.
     */
    class activeData
    {
        /// <summary>
        /// Constructor for activeData class.
        /// </summary>
        /// <param name="numIn"></param>
        /// <param name="titleIn"></param>
        /// <param name="contentIn"></param>
        public activeData(int numIn, string titleIn, string contentIn)
        {
            cardNum = numIn;
            title = titleIn;
            content = contentIn;
        }  
        /// <summary>
        /// Getter method for card number.
        /// </summary>
        /// <returns> card number integer </returns>
        public int getCardNum()
        {
            return cardNum;
        }
        /// <summary>
        /// Getter method for card title string.
        /// </summary>
        /// <returns> title of card </returns>
        public string getTitle()
        {
            return title;
        }
        /// <summary>
        /// Getter method for card content.
        /// </summary>
        /// <returns> card content string </returns>
        public string getContent()
        {
            return content;
        }
        /// <summary>
        /// Setter method for card number element.
        /// </summary>
        /// <param name="numIn"></param>
        public void setCardNum(int numIn)
        {
            cardNum = numIn;
        }
        /// <summary>
        /// Setter method for card title.
        /// </summary>
        /// <param name="titleIn"></param>
        public void setTitle(string titleIn)
        {
            title = titleIn;
        }
        /// <summary>
        /// Setter method for card content.
        /// </summary>
        /// <param name="contentIn"></param>
        /// <returns> integer number of characters written </returns>
        public int setContent(string contentIn)
        {
            content = contentIn;
            return content.Length;
        }
        
        // Private data members
        private int cardNum;
        private string title;
        private string content;
    }
}
