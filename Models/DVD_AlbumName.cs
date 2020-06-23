using System;
using System.Xml;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class DVD_AlbumName
    {        
        [XmlAttribute ("numberSongs")]
        public int number_songs { get; set; }

        [XmlText]
        public string DVD_albumName { get; set; }
    }
}