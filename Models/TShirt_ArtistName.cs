using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class TShirt_ArtistName
    {
        [XmlText]
        [Required]
        public string T_shirt_artist_name { get; set; }
        
        [XmlAttribute ("color")]
        public string color { get; set; }

        [XmlAttribute ("size")]
        [Required]
        public int size { get; set; }
    }
}