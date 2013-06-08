using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace XMLReader
{
    public class Functionalities
    {
        /// <summary>
        /// Creates a new cardfile.
        /// </summary>
        /// <param name="fileName">Name of the cradfile</param>
        public static void newCardFile(string fileName)
        {
            XElement cfile = new XElement("cardfile");

            /*Constants.file = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None);
            StreamWriter writer = new StreamWriter(Constants.file);

            writer.WriteLine("<cardfile>");
            writer.WriteLine("</cardfile>");

            writer.Close();*/

            // default: start with one card
            newCard(0);
        }

        /// <summary>
        /// Opens a cardfile and parses its contents into cache.
        /// </summary>
        /// <param name="filepath">Path to XML cardfile.</param>
        public static void openCard(string filepath)
        {
            // open the file and parse into cache
        }

        /// <summary>
        /// Parses the cache into an XML file and saves it.
        /// </summary>
        /// <param name="filepath">Path to XML cardfile.</param>
        public static void saveCard(string filepath)
        {
            // save all data from cache into XML file
        }

        /// <summary>
        /// Create a new card at the specified location within the cardfile.
        /// </summary>
        /// <param name="currentPosition">Current position of the card that is being viewed.</param>
        public static void newCard(int currentPosition)
        {
            // add new card in current position
            if (currentPosition == 0)
            {
                // add first card
            }
        }

        /// <summary>
        /// Delete a card from the cardfile.
        /// </summary>
        /// <param name="cardNum">Number of the card to be deleted.</param>
        public static void deleteCard(int cardNum)
        {
            //Constants.cache.
        }
    }
}
