using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Vinyl_ArtistName
    {
        [XmlText]
        public string Vinyl_artist_name { get; set; }
        
        [XmlAttribute ("autograph")]
        public Boolean autograph { get; set; }
    }
}