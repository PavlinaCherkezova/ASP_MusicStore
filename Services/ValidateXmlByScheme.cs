using System;
using System.Xml.Schema;
using System.Xml.Linq;

namespace MusicStore.Services
{
    public class ValidateXMLByScheme
    {
        public static bool isValidated(string XSDName, string fileName){
            bool isValid = true;
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add("", XSDName);

            XDocument XMLfile = new XDocument();
            XMLfile = XDocument.Load(fileName);

            if(XMLfile != null){
                XMLfile.Validate(schemaSet, (sc, ex) => {
                    isValid = false;
                });
            }else {
                isValid = false;
            }

            return isValid;
        }
    }
} 
