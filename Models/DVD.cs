using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class DVD
    {
        public DVD()
        {
            this.DVD_album_name = new DVD_AlbumName();
            this.DVD_artist_name = new DVD_ArtistName();
            this.DVD_label_name = "";
            this.DVD_release_date = DateTime.Now;
            this.DVD_price = 0;
            this.DVD_image = "";
        }

        public DVD(DVD_AlbumName DVD_AlbumName, DVD_ArtistName DVD_ArtistName, string DVD_label_name, DateTime DVD_release_date, float DVD_price, string DVD_image)
        {
            this.DVD_album_name = DVD_AlbumName;
            this.DVD_artist_name = DVD_ArtistName;
            this.DVD_label_name = DVD_label_name;
            this.DVD_release_date = DVD_release_date;
            this.DVD_price = DVD_price;
            this.DVD_image = DVD_image;
        }

        [XmlElement ("DVD_album_name")]
        [Required]
        public DVD_AlbumName DVD_album_name { get; set; }

        [XmlElement ("DVD_artist_name")]
        [Required]
        public DVD_ArtistName DVD_artist_name { get; set; }
        public string DVD_label_name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DVD_release_date { get; set; }

        [Required]
        public float DVD_price { get; set; }

        public string DVD_image { get; set; }
    }
}