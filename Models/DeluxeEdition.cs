using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class DeluxeEdition
    {
        public DeluxeEdition(){
            this.Deluxe_album_name = new Deluxe_AlbumName();
            this.Deluxe_artist_name = new Deluxe_ArtistName();
            this.Deluxe_label_name = "";
            this.Deluxe_release_date = new DateTime();
            this.Deluxe_price = 0;
            this.Deluxe_image = "";
        }

        public DeluxeEdition(Deluxe_AlbumName Deluxe_AlbumName, Deluxe_ArtistName Deluxe_ArtistName, string Deluxe_label_name, DateTime Deluxe_release_date, float Deluxe_price, string Deluxe_image){
            this.Deluxe_album_name = Deluxe_AlbumName;
            this.Deluxe_artist_name = Deluxe_ArtistName;
            this.Deluxe_label_name = Deluxe_label_name;
            this.Deluxe_release_date = Deluxe_release_date;
            this.Deluxe_price = Deluxe_price;
            this.Deluxe_image = Deluxe_image;
        }

        [XmlElement ("Deluxe_album_name")]
        public Deluxe_AlbumName Deluxe_album_name { get; set; }

        [XmlElement ("Deluxe_artist_name")]
        public Deluxe_ArtistName Deluxe_artist_name { get; set; }
        public string Deluxe_label_name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Deluxe_release_date { get; set; }

        public float Deluxe_price { get; set; }

        public string Deluxe_image { get; set; }
    }
}