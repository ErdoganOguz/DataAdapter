namespace DataAdapterExample.DataSources
{
    public class XmlDataProvider : IXmlDataProvider
    {
        public string GetXmlData()
        {
            return "<Employee><Name>Jhon Doe</Name><Position>Software Developer</Position></Employee>";
        }
    }
}
