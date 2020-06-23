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


namespace MusicStore.Controllers
{
    public class PagesController : Controller
    {
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
        public ActionResult Form(MusicShopForm input)
        {
            var items = input.DVD;
            ViewData["DVD.DVD_artist_name"] = items;

            return View("Create");
            //return Content($"Hello {input.DVD.DVD_price}");
        } 

        [HttpPost]
        public ActionResult CreateNewEntity (MusicShopForm input)
        {

            Console.WriteLine("here");
            Console.WriteLine(input.DVD.DVD_album_name.DVD_albumName);
            Console.WriteLine(input.DVD.DVD_album_name.number_songs);
            Console.WriteLine(input.DVD.DVD_price);

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

        public void saveData (MusicShop entity){
            var directory = new DirectoryInfo("C:/Users/polic/Desktop/uni/asp/MusicStore/genaretedXMLs");
            var lastFileIndex = directory.GetFiles().Length;
            var file = directory.GetFiles("*" + lastFileIndex + ".xml");

            Serialization.serialize(entity);
        }
    }
}