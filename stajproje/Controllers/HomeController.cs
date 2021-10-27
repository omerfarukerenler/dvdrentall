using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using stajproje.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace stajproje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private object _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            //DvdRentAlContext db = new DvdRentAlContext();
            //var liste = db.Films.AsQueryable().ToList();
            //return View();
            DvdRentAlContext db = new DvdRentAlContext();
            var liste = db.Films.AsQueryable().ToList();
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


        //[HttpPost]

        //public JsonResult AjaxMethod()
        //{
        //    DvdRentAlContext entites = new DvdRentAlContext();
        //    List<Film> films = (from Film in entites.Films
        //                        select Film).ToList();
        //    return Json(films);
        //}
    }
}
