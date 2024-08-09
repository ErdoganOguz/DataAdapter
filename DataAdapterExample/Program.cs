using System;
using DataAdapterExample.Adapters;
using DataAdapterExample.DataSources;
using DataAdapterExample.JsonConsumer;

namespace DataAdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IXmlDataProvider xmlDataProvider = new XmlDataProvider();
            XmlToJsonAdapter adapter = new XmlToJsonAdapter(xmlDataProvider);
            JsonDataConsumer jsonConsumer = new JsonDataConsumer();

            string jsonData = adapter.GetJsonData();
            Console.WriteLine("Converted JSON Data:");
            Console.WriteLine(jsonData);

            Console.WriteLine("\nConsuming JSON Data:");
            jsonConsumer.ConsumeJsonData(jsonData);
        }
    }
}
