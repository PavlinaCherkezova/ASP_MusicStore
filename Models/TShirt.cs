using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class T_Shirt
    {
        T_Shirt(){
            this.TShirt_ArtistName = new TShirt_ArtistName();
            this.T_shirt_price = 0;
            this.T_shirt_image = "";
        }
        T_Shirt(TShirt_ArtistName TShirt_ArtistName, float T_shirt_price, string T_shirt_image){
            this.TShirt_ArtistName = TShirt_ArtistName;
            this.T_shirt_price = T_shirt_price;
            this.T_shirt_image = T_shirt_image;
        }

        [XmlElement ("T_shirt_artist_name")]
        public TShirt_ArtistName TShirt_ArtistName { get; set; }

         [XmlElement ("T-shirt_image")]
        public string T_shirt_image { get; set; }
    
        [XmlElement ("T-shirt_price")]
        public float T_shirt_price { get; set; }
    }
}