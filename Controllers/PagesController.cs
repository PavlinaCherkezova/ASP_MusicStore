using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Models;
using MusicStore.Services;
using System.IO;
using System.Collections;


namespace MusicStore.Controllers
{
    public class PagesController : Controller
    {
        private const string loadedXMLsLocation = "C:/Users/polic/Desktop/uni/asp/MusicStore/loadXMLs";
        private const string XSDSchema = "C:/Users/polic/Desktop/uni/asp/MusicStore/XSD schema/MusicStore.xsd";
        private readonly DBAccsessService _dBAccsessService;
        private static List<FileStatus> file
        public PagesController(DBAccsessService dBAccsessService)
        {
            _dBAccsessService = dBAccsessService;
        }
        public IActionResult Create ()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNewEntity (MusicShopForm input)
        {
            MusicShop entity = new MusicShop();
            
            if(input.CD != null) {
                entity.CDs.CDList.Add(input.CD);
            }
            if(input.DVD != null) {
                entity.DVDs.DVDList.Add(input.DVD);
            }
            if(input.Vinyl != null) {
                entity.Vinyls.VinylList.Add(input.Vinyl);
            }
            if(input.DeluxeEdition != null) {
                entity.DeluxeEditions.DeluxeEditionList.Add(input.DeluxeEdition);
            }
            if(input.T_Shirt != null) {
                entity.FanMerchandise.TShirts.TShirtList.Add(input.T_Shirt);
            }

            saveData(entity);
            ModelState.Clear();

            return View("Form");
        }

        private void saveData (MusicShop entity) {
            var directory = new DirectoryInfo("C:/Users/polic/Desktop/uni/asp/MusicStore/genaretedXMLs");
            var guid = Guid.NewGuid().ToString();
            var fileName = $"{directory}/xml_{guid}.xml";

            Serialization.serialize(entity, fileName);
            if (entity.CDs != null && entity.CDs.CDList != null)
            {
                foreach (var cd in entity.CDs.CDList)
                {
                    _dBAccsessService.SaveCDToDB(cd);
                }
                _dBAccsessService.saveChanges(); //fileStatus - isAlreadyAdded
            }
       
        }

        [HttpGet]
        public ActionResult LoadFiles () {
            string[] fileNames = Directory.GetFiles(loadedXMLsLocation).Select(file => Path.GetFileName(file)).ToArray();
            List<FileStatus> fileStatuses = new List<FileStatus>();
            var foo = new FileStatus();

            foreach (string fileName in fileNames){
                FileStatus entity = null;
                
                if(ValidateXMLByScheme.isValidated(XSDSchema, fileName)){
                    MusicShop DBentity = Serialization.deserialize(fileName);
                    if(DBentity.CDs != null && DBentity.CDs.CDList != null)
                    {
                        foreach(var cd in DBentity.CDs.CDList)
                        {
                            _dBAccsessService.SaveCDToDB(cd);
                        }
                        _dBAccsessService.saveChanges();
                    }
                    //if(DBAccsessService.saveToDB(DBentity)){
                    //    entity = new FileStatus(fileName, "Success", true, true);
                    //}else {
                    //    entity = new FileStatus(fileName, "Success", true, false);
                    //}
                }else {
                   // entity = new FileStatus(fileName, "Failure", false, false);
                }

                fileStatuses.Add(entity);
            }

            return View("GetLoadedFiles", foo);
        }
        [HttpGet]
        public ActionResult GetLoadedFiles()
        {
            var foo = new FileStatus();
            return View(foo); 
        }
    }
}
