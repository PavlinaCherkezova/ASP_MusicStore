using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Vinyl_ArtistName
    {
        [XmlText]
        [Required]
        public string Vinyl_artist_name { get; set; }
        
        [XmlAttribute ("autograph")]
        public Boolean autograph { get; set; }
    }
}