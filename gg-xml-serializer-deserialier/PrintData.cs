using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg_xml_serializer_deserialier
{
    public class PrintData
    {
        public string data { get; set; }
        public string fontType { get; set;}
        public string fontSize { get; set; }
        public string XAxis { get; set; }
        public string YAxis { get; set; }
    }

    public class PrintDataList
    {
        public List<PrintData> PrintData { get; set; }
    }
}
