using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class TShirts
    {
        public TShirts()
        {
            TShirtList = new List<T_Shirt>();
        }
        [XmlElement ("T-shirt")]
        public List<T_Shirt> TShirtList { get; set; }
    }
}