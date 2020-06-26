using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Vinyls
    {
        [XmlElement ("Vinyl")]
        public List<VinylModel> VinylList = new List<VinylModel>();
    }
}