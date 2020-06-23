using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class DVDs
    {
        [XmlElement ("DVD")]
        public List<DVD> DVDList = new List<DVD>();
    }
}