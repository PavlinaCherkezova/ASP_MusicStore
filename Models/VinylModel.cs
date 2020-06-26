using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class VinylModel
    {
        public VinylModel()
        {
            this.Vinyl_album_name = new Vinyl_AlbumName();
            this.Vinyl_artist_name = new Vinyl_ArtistName();
            this.Vinyl_label_name = "";
            this.Vinyl_release_date = new DateTime();
            this.Vinyl_price = 0;
            this.Vinyl_image = "";
        }

        public VinylModel(Vinyl_AlbumName Vinyl_AlbumName, Vinyl_ArtistName Vinyl_ArtistName, string Vinyl_label_name, DateTime Vinyl_release_date, float Vinyl_price, string Vinyl_image)
        {
            this.Vinyl_album_name = Vinyl_AlbumName;
            this.Vinyl_artist_name = Vinyl_ArtistName;
            this.Vinyl_label_name = Vinyl_label_name;
            this.Vinyl_release_date = Vinyl_release_date;
            this.Vinyl_price = Vinyl_price;
            this.Vinyl_image = Vinyl_image;
        }

        [XmlElement ("Vinyl_album_name")]
        [Required]
        public Vinyl_AlbumName Vinyl_album_name { get; set; }

        [XmlElement ("Vinyl_artist_name")]
        [Required]
        public Vinyl_ArtistName Vinyl_artist_name { get; set; }
        public string Vinyl_label_name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Vinyl_release_date { get; set; }

        [Required]
        public float Vinyl_price { get; set; }

        public string Vinyl_image { get; set; }
    }
}