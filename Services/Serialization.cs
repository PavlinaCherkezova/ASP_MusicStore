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
        public static void Serialize (MusicShop entity, string fileName)
        {
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

        public static MusicShop Deserialize (string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MusicShop));
            TextReader reader = new StreamReader(fileName);
            MusicShop result = (MusicShop)serializer.Deserialize(reader);
            reader.Close();

            return result;
        }
    }
}