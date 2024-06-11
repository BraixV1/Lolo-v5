using System.Xml.Serialization;

namespace WebApp.Helpers;

public class XMLDeserializer
{
    public static T DeserializeXmlData<T>(string xmlData)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(T));
        using StringReader reader = new StringReader(xmlData);
        return (T)serializer.Deserialize(reader);
    }
}