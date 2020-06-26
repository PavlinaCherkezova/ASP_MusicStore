using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Vinyl_AlbumName
    {
        [XmlText]
        [Required]
        public string Vinyl_album_name { get; set; }
        
        [XmlAttribute ("numberSongs")]
        public int number_songs { get; set; }
    }
}