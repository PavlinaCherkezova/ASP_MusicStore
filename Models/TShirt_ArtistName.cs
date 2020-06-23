using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class TShirt_ArtistName
    {
        [XmlText]
        public string T_shirt_artist_name { get; set; }
        
        [XmlAttribute ("color")]
        public string color { get; set; }

        [XmlAttribute ("size")]
        public int size { get; set; }
    }
}