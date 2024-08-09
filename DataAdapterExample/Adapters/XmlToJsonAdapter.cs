using System.Xml;
using Newtonsoft.Json;
using DataAdapterExample.DataSources;

namespace DataAdapterExample.Adapters
{
    public class XmlToJsonAdapter
    {
        private readonly IXmlDataProvider _xmlDataProvider;

        public XmlToJsonAdapter(IXmlDataProvider xmlDataProvider)
        {
            _xmlDataProvider = xmlDataProvider;
        }

        public string GetJsonData()
        {
            string xmlData = _xmlDataProvider.GetXmlData();
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlData);
            return JsonConvert.SerializeXmlNode(doc.DocumentElement);
        }
    }
}

