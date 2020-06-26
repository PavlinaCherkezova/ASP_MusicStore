using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Deluxe
    {
        public Deluxe()
        {
            this.Deluxe_album_name = new Deluxe_AlbumName();
            this.Deluxe_artist_name = new Deluxe_ArtistName();
            this.Deluxe_label_name = "";
            this.Deluxe_release_date = DateTime.Now;
            this.Deluxe_price = 0;
            this.Deluxe_image = "";
        }

        public Deluxe(Deluxe_AlbumName Deluxe_AlbumName, Deluxe_ArtistName Deluxe_ArtistName, string Deluxe_label_name, DateTime Deluxe_release_date, float Deluxe_price, string Deluxe_image)
        {
            this.Deluxe_album_name = Deluxe_AlbumName;
            this.Deluxe_artist_name = Deluxe_ArtistName;
            this.Deluxe_label_name = Deluxe_label_name;
            this.Deluxe_release_date = Deluxe_release_date;
            this.Deluxe_price = Deluxe_price;
            this.Deluxe_image = Deluxe_image;
        }

        [XmlElement ("Deluxe_album_name")]
        [Required]
        public Deluxe_AlbumName Deluxe_album_name { get; set; }

        [XmlElement ("Deluxe_artist_name")]
        [Required]
        public Deluxe_ArtistName Deluxe_artist_name { get; set; }
        public string Deluxe_label_name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Deluxe_release_date { get; set; }

        [Required]
        public float Deluxe_price { get; set; }

        public string Deluxe_image { get; set; }
    }
}