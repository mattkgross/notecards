using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace Resources
{
    public class Constants
    {
        /* Files, I/O, & Cache */
        public static FileStream file;
        // XML tools
        public static XmlReader reader;
        public static XmlWriter writer;
        // Card Cache
        public static List<activeData> cache;

        /* Trackers */
        // Bool to keep track of unsaved changes
        public static bool changes;
    }
}
