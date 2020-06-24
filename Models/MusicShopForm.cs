using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class MusicShopForm
    {
        public CD CD { get; set; }

        public DVD DVD  { get; set; }

        public Vinyl Vinyl { get; set; }

        public DeluxeEdition DeluxeEdition { get; set; }
        
        public T_Shirt T_Shirt { get; set; }
       
    }
}