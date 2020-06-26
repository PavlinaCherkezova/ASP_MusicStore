using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Deluxe_AlbumName
    {
        [XmlText]
        [Required]
        public string Deluxe_album_name { get; set; }
        
        [XmlAttribute ("numberSongs")]
        public int number_songs { get; set; }
    }
}