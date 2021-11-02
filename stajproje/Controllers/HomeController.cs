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
            var test = db.Films.AsQueryable().ToList();
            return View();




        }

        public IActionResult Privacy()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test1 = db.Categories.AsQueryable().ToList();
            return View();
        }

        public IActionResult Payment()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test2 = db.Payments.AsQueryable().ToList();
            return View();

        }

        public IActionResult Staffsss()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test3 = db.StaffLists.AsQueryable().ToList();
            return View();

        }
        public IActionResult Actor()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test4 = db.Actors.AsQueryable().ToList();
            return View();

        }

        public IActionResult Country()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test5 = db.Countries.AsQueryable().ToList();
            return View();

        }

        public IActionResult Customer()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test6 = db.Customers.AsQueryable().ToList();
            return View();

        }


        public IActionResult Inventory()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test7 = db.Inventories.AsQueryable().ToList();
            return View();

        }
        public IActionResult Address()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test8 = db.Addresses.AsQueryable().ToList();
            return View();

        }

        public IActionResult Store()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test9 = db.Countries.AsQueryable().ToList();
            return View();

        }

        public IActionResult Language()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test10 = db.Languages.AsQueryable().ToList();
            return View();

        }

        public IActionResult City()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test11 = db.Cities.AsQueryable().ToList();
            return View();

        }

        public IActionResult Rental()
        {
            DvdRentAlContext db = new DvdRentAlContext();
            var test12 = db.Rentals.AsQueryable().ToList();
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost]

        public JsonResult AjaxMethod()
        {
            DvdRentAlContext entities = new DvdRentAlContext();
            var films = (from Film in entities.Films
                                select Film).ToList();
                
           
            return Json(films);
           
        }

        [HttpPost]
        public JsonResult Filmcategory()
        {
            DvdRentAlContext dvd = new DvdRentAlContext();
            var categories = (from Category in dvd.Categories
                         select Category).ToList();

            return Json(categories);

        }



        [HttpPost]
        public JsonResult PaymentCategory()
        {
            DvdRentAlContext dvdRentAlContext = new DvdRentAlContext();
            var payments = (from Payment in dvdRentAlContext.Payments
                              select Payment).ToList();

            return Json(payments);

        }


        [HttpPost]
        public JsonResult Staffinfo()
        {
            DvdRentAlContext dvdRentAl = new DvdRentAlContext();
            var staff = (from StaffList in dvdRentAl.staff
                            select StaffList).ToList();

            return Json(staff);

        }


        [HttpPost]
        public JsonResult Actorfilm()
        {
            DvdRentAlContext rent = new DvdRentAlContext();
            var actor = (from Actor in rent.Actors
                         select Actor).ToList();

            return Json(actor);

        }


        [HttpPost]
        public JsonResult CountryList()
        {
            DvdRentAlContext rentAlContextt = new DvdRentAlContext();
            var country = (from Country in rentAlContextt.Countries
                         select Country).ToList();

            return Json(country);

        }

        [HttpPost]
        public JsonResult CustomerList()
        {
            DvdRentAlContext rentAlContexttt = new DvdRentAlContext();
            var customer = (from Customer in rentAlContexttt.Customers
                           select Customer).ToList();

            return Json(customer);

        }


        [HttpPost]
        public JsonResult InventoryList()
        {
            DvdRentAlContext rentAlContextttt = new DvdRentAlContext();
            var inventory = (from Inventory in rentAlContextttt.Inventories
                            select Inventory).ToList();

            return Json(inventory);

        }


        [HttpPost]
        public JsonResult AddressList()
        {
            DvdRentAlContext rentAlContexttttt = new DvdRentAlContext();
            var address = (from Address in rentAlContexttttt.Addresses
                             select Address).ToList();

            return Json(address);

        }


        [HttpPost]
        public JsonResult StoreList()
        {
            DvdRentAlContext rentAlContextttttt = new DvdRentAlContext();
            var store = (from Store in rentAlContextttttt.Stores
                           select Store).ToList();

            return Json(store);

        }


        [HttpPost]
        public JsonResult LanguageList()
        {
            DvdRentAlContext rentAlContexttttttt = new DvdRentAlContext();
            var language = (from Language in rentAlContexttttttt.Languages
                         select Language).ToList();

            return Json(language);

        }

        [HttpPost]
        public JsonResult CityList()
        {
            DvdRentAlContext rentAlContextttttttt = new DvdRentAlContext();
            var city = (from City in rentAlContextttttttt.Cities
                            select City).ToList();

            return Json(city);

        }

        [HttpPost]
        public JsonResult RentalList()
        {
            DvdRentAlContext rentAlContexttttttttt = new DvdRentAlContext();
            var rental = (from Rental in rentAlContexttttttttt.Rentals
                        select Rental).ToList();

            return Json(rental);

        }




    }
}
