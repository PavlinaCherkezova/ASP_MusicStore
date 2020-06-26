using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using MusicStore.Services;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Net;

namespace MusicStore.Controllers
{
    public class PagesController : Controller
    {
        private static Dictionary<string, FileStatus> fileStatuses = new Dictionary<string ,FileStatus>();
        private readonly DBAccsessService _dBAccsessService;
        private readonly IConfiguration _config;

        private string LoadedXMLsLocation { get; set; }
        private string GeneratedXMLsLocation { get; set; }
        private string XSDSchema { get; set; }
        public PagesController(DBAccsessService dBAccsessService, IConfiguration config)
        {
            _dBAccsessService = dBAccsessService;
            _config = config;
            LoadedXMLsLocation = _config.GetValue<string>("XmlLoadedFilesPath");
            GeneratedXMLsLocation = _config.GetValue<string>("XmlGeneratedFilesPath");
            XSDSchema = _config.GetValue<string>("XSDSchema");
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetLoadedFiles()
        {
            var fileStatus = new FileStatus();
            return View(fileStatus);
        }

        [HttpPost]
        public ActionResult CreateNewEntity(MusicShopForm input)
        {
                MusicShop entity = new MusicShop();

                if (input.CD != null)
                {
                    entity.CDs.CDList.Add(input.CD);
                }
                if (input.DVD != null)
                {
                    entity.DVDs.DVDList.Add(input.DVD);
                }
                if (input.Vinyl != null)
                {
                    entity.Vinyls.VinylList.Add(input.Vinyl);
                }
                if (input.DeluxeEdition != null)
                {
                    entity.DeluxeEditions.DeluxeEditionList.Add(input.DeluxeEdition);
                }
                if (input.T_Shirt != null)
                {
                    entity.FanMerchandise.TShirts.TShirtList.Add(input.T_Shirt);
                }

                SaveData(entity);
                ModelState.Clear();

                return View("GetLoadedFiles", fileStatuses);
        }

        private void SaveData(MusicShop entity) {
            var directory = new DirectoryInfo(GeneratedXMLsLocation);
            var guid = Guid.NewGuid().ToString();
            var fileName = $"xml_{guid}.xml";
            var filePath = $"{directory}/{fileName}";
            
            Serialization.Serialize(entity, filePath);
            SendToDB(entity, fileName);
        }

        [HttpGet]
        public ActionResult LoadFiles() {
            var fileNames = Directory.GetFiles(LoadedXMLsLocation).Select(file => Path.GetFileName(file)).ToArray();

            foreach (string fileName in fileNames) 
            {
                var fullFilePath = LoadedXMLsLocation + fileName;
                if (ValidateXMLByScheme.isValidated(XSDSchema, fullFilePath)) 
                {
                    MusicShop DBentity = Serialization.Deserialize(fullFilePath);
                    SendToDB(DBentity, fileName);
                } 
                else {
                    if(!fileStatuses.Keys.Contains(fileName))
                    {
                        fileStatuses.Add(fileName, new FileStatus
                        {
                            fileName = fileName,
                            isValid = false,
                            isAlreadyAdded = false,
                            status = "Failed"
                        });
                    } 
                }
            }

            return View("GetLoadedFiles", fileStatuses);
        }

        public void SendToDB(MusicShop DBentity, string FileName)
        {
            bool isEntitiyExisting = true;
            if (DBentity.CDs != null && DBentity.CDs.CDList != null)
            {
                foreach (var cd in DBentity.CDs.CDList)
                {
                    isEntitiyExisting = _dBAccsessService.SaveCDToDB(cd);
                }
            }

            if (DBentity.DVDs != null && DBentity.DVDs.DVDList != null)
            {
                foreach (var dvd in DBentity.DVDs.DVDList)
                {
                    isEntitiyExisting =_dBAccsessService.SaveDVDToDB(dvd);
                }
            }

            if (DBentity.Vinyls != null && DBentity.Vinyls.VinylList != null)
            {
                foreach (var vinyl in DBentity.Vinyls.VinylList)
                {
                    isEntitiyExisting = _dBAccsessService.SaveVinylToDB(vinyl);
                }
            }

            if (DBentity.DeluxeEditions != null && DBentity.DeluxeEditions.DeluxeEditionList != null)
            {
                foreach (var deluxe in DBentity.DeluxeEditions.DeluxeEditionList)
                {
                    isEntitiyExisting =  _dBAccsessService.SaveDeluxeToDB(deluxe);
                }
            }

            if (DBentity.FanMerchandise != null && DBentity.FanMerchandise.TShirts != null && DBentity.FanMerchandise.TShirts.TShirtList != null)
            {
                foreach (var t_Shirt in DBentity.FanMerchandise.TShirts.TShirtList)
                {
                    isEntitiyExisting = _dBAccsessService.SaveTShirtToDB(t_Shirt);
                }
            }

            var changesSaved = _dBAccsessService.SaveChanges();
            var isAddedToDB = !isEntitiyExisting && changesSaved ? true : false;
            if (!fileStatuses.Keys.Contains(FileName))
            {
                fileStatuses.Add(FileName, new FileStatus
                {
                    fileName = FileName,
                    isValid = true,
                    isAlreadyAdded = !isAddedToDB,
                    status = isAddedToDB ? "Success" : "Failed"
                });
            }
        }
    }
}
