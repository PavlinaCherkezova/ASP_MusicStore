using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class CD_AlbumName
    {
        [XmlText]
        [Required]
        public string CD_album_name { get; set; }
        
        [XmlAttribute ("numberSongs")]
        public int number_songs { get; set; }

        public CD_AlbumName()
        {
            this.CD_album_name = "";
            this.number_songs = 0;
        }
        public CD_AlbumName(string CD_album_name, int number_songs)
        {
            this.CD_album_name = CD_album_name;
            this.number_songs = number_songs;
        }
    }
}