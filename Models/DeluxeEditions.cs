using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class DeluxeEditions
    {
        [XmlElement ("DeluxeEdition")]
        public List<Deluxe> DeluxeEditionList = new List<Deluxe>();
    }
}