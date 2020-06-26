using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class CD_ArtistName
    {
        [XmlText]
        [Required]
        public string CD_artist_name { get; set; }

        [XmlAttribute ("autograph")]
        public Boolean autograph { get; set; }
        public CD_ArtistName()
        {
            this.CD_artist_name = "";
            this.autograph = false;
        }
        public CD_ArtistName(string CD_artist_name, bool autograph)
        {
            this.CD_artist_name = CD_artist_name;
            this.autograph = autograph;
        }
    }
}