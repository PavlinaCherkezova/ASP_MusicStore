using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class FanMerchandise
    {
        public FanMerchandise()
        {
            TShirts = new TShirts();
        }
        [XmlElement ("T-shirts")]
        public TShirts TShirts { get; set; }
    }
}