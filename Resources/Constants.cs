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
    class Constants
    {
        internal static FileStream file;
        // XML tools
        internal static XmlReader reader;
        internal static XmlWriter writer;
        // Card Cache
        internal List<activeData> cache;
    }
}
