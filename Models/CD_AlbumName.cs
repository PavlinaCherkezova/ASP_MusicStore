using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class CD_AlbumName
    {
        [XmlText]
        public string CD_album_name { get; set; }
        
        [XmlAttribute ("numberSongs")]
        public int number_songs { get; set; }
    }
}