using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class CDs
    {
        [XmlElement ("CD")]
        public List<CD> CDList = new List<CD>();
    }
}