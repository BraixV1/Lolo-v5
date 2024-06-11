using System.Xml.Serialization;

namespace WebApp.Helpers;

public class Article
{
    [XmlElement("guid")]
    public string Guid { get; set; } = default!;

    [XmlElement("title")]
    public string Title { get; set; } = default!;
    
    [XmlElement("pubDate")]
    public string PubDateString { get; set; }

    
    [XmlIgnore]
    public DateTime pubDate
    {
        get
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(PubDateString, "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.AdjustToUniversal,
                    out parsedDate))
            {
                return parsedDate;
            }
            else
            {
                // Handle the error as needed
                return DateTime.MinValue;
            }
        }
        set
        {
            PubDateString = value.ToString("ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                System.Globalization.CultureInfo.InvariantCulture);
        }
    }

    [XmlElement("description")]
    public string Description { get; set; } = default!;

    [XmlElement("author")]
    public string Author { get; set; } = default!;

    [XmlElement(ElementName = "content", Namespace = "http://search.yahoo.com/mrss/")]
    public MediaContent Media { get; set; } = default!;

    [XmlElement("category")]
    public List<string> Categories { get; set; } = default!;

    [XmlElement("link")] 
    public string LinkToArticle { get; set; } = default!;

    [XmlIgnore] public string Color { get; set; } = default!;
}

[XmlRoot("rss")]
public class ArticlesObj
{
    [XmlArray("channel")]
    [XmlArrayItem("item")]
    public List<Article> Articles { get; set; } = default!;
}


public class MediaContent
{
    [XmlAttribute("url")]
    public string Url { get; set; } = default!;
}
