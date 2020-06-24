using System;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using MusicStore.Models;

namespace MusicStore.Services
{
    [Serializable, XmlRoot ("MusicShop")]
    public class Serialization
    {
        const string directory = "C:/Users/polic/Desktop/uni/asp/MusicStore/genaretedXMLs";

        public static void serialize (MusicShop entity, string fileName){
            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(typeof (MusicShop));
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, entity);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(fileName);
            }
        }

        public static MusicShop deserialize (string fileName){
            XmlSerializer serializer = new XmlSerializer(typeof (MusicShop));
            var result = new MusicShop();

            using (FileStream fileStream = new FileStream(fileName, FileMode.Open)){
                result = (MusicShop)serializer.Deserialize(fileStream);
            }

            return result;
        }
    }
}