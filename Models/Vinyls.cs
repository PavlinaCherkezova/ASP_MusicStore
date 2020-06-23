using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class Vinyls
    {
        [XmlElement ("Vinyl")]
        public List<Vinyl> VinylList = new List<Vinyl>();
    }
}