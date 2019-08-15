using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopNetCore.Data.Interfaces;

namespace ShopNetCore.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategory;

        public CarsController(IAllCars allCars, ICarsCategory allCategory)
        {
            _allCars = allCars;
            _allCategory = allCategory;
        }

        public IActionResult List()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}