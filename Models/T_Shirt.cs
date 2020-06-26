using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class T_Shirt
    {
        public T_Shirt(){
            this.TShirt_ArtistName = new TShirt_ArtistName();
            this.T_shirt_price = 0;
            this.T_shirt_image = "";
        }

        [XmlElement ("T_shirt_artist_name")]
        [Required]
        public TShirt_ArtistName TShirt_ArtistName { get; set; }

         [XmlElement ("T-shirt_image")]
        [Required]
        public string T_shirt_image { get; set; }
    
        [XmlElement ("T-shirt_price")]
        public float T_shirt_price { get; set; }
    }
}