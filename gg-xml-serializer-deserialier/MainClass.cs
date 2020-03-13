using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gg_xml_serializer_deserialier
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Serialization/Deserialization");
            Console.WriteLine("-----Serialized Employee Data-----");
            Console.WriteLine("--------------------------------------------------------------------------------");

            SerializerDeserializer<PrintDataList> serializePrint;

            var dataList = new PrintDataList();
            dataList.PrintData = new List<PrintData>();
            dataList.PrintData.Add(new PrintData { data = "First XML Print Data", fontType = "Arial", fontSize = "12", XAxis = "100", YAxis = "100" });
            dataList.PrintData.Add(new PrintData { data = "Second XML Print Data", fontType = "Arial", fontSize = "12", XAxis = "100", YAxis = "100" });
            serializePrint = new SerializerDeserializer<PrintDataList>();
            string serializedPrintData = serializePrint.SerializeData(dataList);
            Console.WriteLine("Serialized Print Data : ");
            Console.WriteLine(serializedPrintData);
            Console.WriteLine("--------------------------------------------------------------------------------");



            Console.WriteLine("-----Deserialized Employee Data-----");
            PrintDataList deserialiedPrintData = serializePrint.DeserializeData(serializedPrintData);
            foreach (PrintData pd in deserialiedPrintData.PrintData)
            {
                Console.WriteLine("Print Data : {0} ,  FontType :{1} ,FontSize :{2}, Xaxis :{3}, Yaxis :{4} ", pd.data, pd.fontType, pd.fontSize, pd.XAxis, pd.YAxis);
            }
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ReadLine();
        }
    }
}
