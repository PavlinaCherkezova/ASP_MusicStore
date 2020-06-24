using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    [Serializable, XmlRoot ("MusicShop")]
    public class MusicShop
    {
        public MusicShop (){
            this.CDs = new CDs();
            this.DVDs = new DVDs();
            this.Vinyls = new Vinyls();
            this.DeluxeEditions = new DeluxeEditions();
            this.FanMerchandise = new FanMerchandise();
        }
        public MusicShop(CDs CDs, DVDs DVDs, Vinyls Vinyls, DeluxeEditions DeluxeEditions, FanMerchandise FanMerchandise){
            this.CDs = CDs;
            this.DVDs = DVDs;
            this.Vinyls = Vinyls;
            this.DeluxeEditions = DeluxeEditions;
            this.FanMerchandise = FanMerchandise;
        } 
        [XmlElement ("CDs")]
        public CDs CDs { get; set; }

        [XmlElement ("DVDs")]
        public DVDs DVDs  { get; set; }

        [XmlElement ("Vinyls")]
        public Vinyls Vinyls { get; set; }

        [XmlElement ("DeluxeEditions")]
        public DeluxeEditions DeluxeEditions { get; set; }
        
        [XmlElement ("FanMerchandise")]
        public FanMerchandise FanMerchandise { get; set; }
       
    }
}