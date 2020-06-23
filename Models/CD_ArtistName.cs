using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class CD_ArtistName
    {
        [XmlText]
        public string CD_artist_name { get; set; }

        [XmlAttribute ("autograph")]
        public Boolean autograph { get; set; }
    }
}