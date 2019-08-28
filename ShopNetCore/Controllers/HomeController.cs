using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopNetCore.Data.Interfaces;
using ShopNetCore.Data.Models;
using ShopNetCore.ViewModels;

namespace ShopNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _cartRep;


        public HomeController(IAllCars cartRep)
        {
            _cartRep = cartRep;
        }
        public IActionResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _cartRep.GetFavCars
            };
            return View(homeCars);
        }
    }
}