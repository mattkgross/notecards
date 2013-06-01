using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;

namespace XMLReader
{
    public class Constants
    {
        internal static FileStream file;
    }

    public class Functionalities
    {
        public static void newCard(string fileName)
        {
            Constants.file = new FileStream(fileName, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.None);
            StreamWriter writer = new StreamWriter(Constants.file);

            writer.WriteLine("<cardfile>");
            writer.WriteLine("</cardfile>");

            writer.Close();
        }
    }
}
