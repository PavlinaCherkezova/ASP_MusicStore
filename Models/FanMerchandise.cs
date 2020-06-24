using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class FanMerchandise
    {
        [XmlElement ("T-shirts")]
        public TShirts TShirts { get; set; }
    }
}