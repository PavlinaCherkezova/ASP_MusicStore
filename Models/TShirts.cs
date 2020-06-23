using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class TShirts
    {
        [XmlElement ("T-shirt")]
        public List<T_Shirt> TShirtList = new List<T_Shirt>();
    }
}