using System.Xml.Serialization;

namespace WildFiresBackend.Data
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Rss));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Rss)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "guid")]
    public class Guid
    {

        [XmlAttribute(AttributeName = "isPermaLink")]
        public bool IsPermaLink { get; set; }

        [XmlText]
        public int Text { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "pubDate")]
        public string PubDate { get; set; }

        [XmlElement(ElementName = "creator")]
        public string Creator { get; set; }

        [XmlElement(ElementName = "guid")]
        public Guid Guid { get; set; }
    }

    [XmlRoot(ElementName = "channel")]
    public class Channel
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        [XmlElement(ElementName = "link")]
        public string Link { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }

        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "rss")]
    public class Rss
    {

        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }

        [XmlAttribute(AttributeName = "dc")]
        public string Dc { get; set; }

        [XmlAttribute(AttributeName = "content")]
        public string Content { get; set; }

        [XmlAttribute(AttributeName = "foaf")]
        public string Foaf { get; set; }

        [XmlAttribute(AttributeName = "og")]
        public string Og { get; set; }

        [XmlAttribute(AttributeName = "rdfs")]
        public string Rdfs { get; set; }

        [XmlAttribute(AttributeName = "schema")]
        public string Schema { get; set; }

        [XmlAttribute(AttributeName = "sioc")]
        public string Sioc { get; set; }

        [XmlAttribute(AttributeName = "sioct")]
        public string Sioct { get; set; }

        [XmlAttribute(AttributeName = "skos")]
        public string Skos { get; set; }

        [XmlAttribute(AttributeName = "xsd")]
        public string Xsd { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public double Version { get; set; }

        [XmlAttribute(AttributeName = "base")]
        public string Base { get; set; }

        [XmlText]
        public string Text { get; set; }
    }


}
