using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BakeryShop.Models;
using BakeryShop2020.Data;
using Microsoft.AspNetCore.Mvc;
using MVCAPP.Models;
using MVCAPP.ViewModels;

namespace MVCAPP.Controllers
{
    public class HomeController : Controller
    {
        private BakeryDBContext db;
        public HomeController(BakeryDBContext db) => this.db = db;


        public IActionResult Index()
        {
            ProductViewModel model = new ProductViewModel();
            model.Products = db.Products.ToList();
            Random rdm = new Random();
            model.FeaturedProduct = db.Products.ElementAt(rdm.Next(0, db.Products.Count()));
                //model.Products.ElementAt(new Random().Next(model.Products.Count));
            return View(model);
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
    }
}
