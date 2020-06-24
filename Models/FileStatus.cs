using System;
using System.Xml.Serialization;

namespace MusicStore.Models
{
    public class FileStatus {
        public string fileName { get; set; }
        public string status { get; set; }
        public bool isValid { get; set; }
        public bool isAlreadyAdded { get; set; }
        public FileStatus(){
            this.fileName = "";
            this.status = "";
            this.isValid = false;
            this.isAlreadyAdded = false;
        }
    }
}