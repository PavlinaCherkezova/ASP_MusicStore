using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Deluxe_ArtistName
    {
        [XmlText]
        public string Deluxe_artist_name { get; set; }
        
          [XmlAttribute ("autograph")]
        public Boolean autograph { get; set; }
    }
}