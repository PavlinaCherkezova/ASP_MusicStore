using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class MusicShopForm
    {
        public CD CD { get; set; }

        public DVD DVD  { get; set; }

        public VinylModel Vinyl { get; set; }

        public Deluxe DeluxeEdition { get; set; }
        
        public T_Shirt T_Shirt { get; set; }
       
    }
}