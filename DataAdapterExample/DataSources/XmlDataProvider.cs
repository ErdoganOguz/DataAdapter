namespace DataAdapterExample.DataSources
{
    public class XmlDataProvider : IXmlDataProvider
    {
        public string GetXmlData()
        {
            return "<Employee><Name>Oğuz ERDOĞAN</Name><Position>Software Developer</Position></Employee>";
        }
    }
}
