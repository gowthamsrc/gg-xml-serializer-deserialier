using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace gg_xml_serializer_deserialier
{
    public class SerializerDeserializer<T>
    {
        StringBuilder sbData;
        StringWriter swWriter;
        XmlDocument xDoc;
        XmlNodeReader xNodeReader;
        XmlSerializer xmlSerializer;
        public SerializerDeserializer()
        {
            sbData = new StringBuilder();
        }

        public string SerializeData(T data)
        {

            XmlSerializer printSerializer = new XmlSerializer(typeof(T));
            swWriter = new StringWriter(sbData);
            printSerializer.Serialize(swWriter, data);
            return sbData.ToString();
        }

        public T DeserializeData(string dataXML)
        {
            xDoc = new XmlDocument();
            xDoc.LoadXml(dataXML);
            xNodeReader = new XmlNodeReader(xDoc.DocumentElement);
            xmlSerializer = new XmlSerializer(typeof(T));
            var printData = xmlSerializer.Deserialize(xNodeReader);
            T deserializedPrint = (T)printData;
            return deserializedPrint;
        }
    }
}
