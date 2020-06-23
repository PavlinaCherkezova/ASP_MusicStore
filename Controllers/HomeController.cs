using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult CreateNewEntity (MusicShopForm input)
        {
            Console.WriteLine("hereeee");
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

            //saveData(entity);

            return View();
        }
    }
}
