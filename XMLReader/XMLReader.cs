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
    public class Constants
    {
        internal static FileStream file;
        // XML tools
        internal static XmlReader reader;
        internal static XmlWriter writer;
        // Card Cache

    }

    public class Functionalities
    {
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

        public static void newCard(int currentPosition)
        {
            // add new card in current position
            if (currentPosition == 0)
            {
                // add first card
            }
        }

        public static void deleteCard()
        {
            // delete current card
        }
    }
}
