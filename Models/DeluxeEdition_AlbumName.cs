using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Deluxe_AlbumName
    {
        [XmlText]
        public string Deluxe_album_name { get; set; }
        
        [XmlAttribute ("numberSongs")]
        public int number_songs { get; set; }
    }
}