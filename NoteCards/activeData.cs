using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteCards
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
        }  
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getCardNum();
        public string getTitle();
        public string getContent();
            bool setCardNum(int numIn);
            bool setTitle(string titleIn);
            int setContent(string contentIn);
        private:
            int cardNum;
            string title;
            string content;
    }
}
