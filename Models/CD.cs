using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class CD
    {
        public CD(){
            this.CD_album_name = new CD_AlbumName();
            this.CD_artist_name = new CD_ArtistName();
            this.CD_label_name = "";
            this.CD_release_date = new DateTime();
            this.CD_price = 0;
            this.CD_image = "";
        }

        public CD(CD_AlbumName cD_AlbumName, CD_ArtistName CD_ArtistName, string CD_label_name, DateTime CD_release_date, float CD_price, string CD_image){
            this.CD_album_name = cD_AlbumName;
            this.CD_artist_name = CD_ArtistName;
            this.CD_label_name = CD_label_name;
            this.CD_release_date = CD_release_date;
            this.CD_price = CD_price;
            this.CD_image = CD_image;
        }

        [XmlElement ("CD_album_name")]
        public CD_AlbumName CD_album_name { get; set; }

        [XmlElement ("CD_artist_name")]
        public CD_ArtistName CD_artist_name { get; set; }
        public string CD_label_name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime  CD_release_date { get; set; }

        public float CD_price { get; set; }

        public string CD_image { get; set; }
    }
}