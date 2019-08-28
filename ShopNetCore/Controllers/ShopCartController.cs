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
    public class ShopCartController : Controller
    {
        private readonly IAllCars _cartRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars cartRep, ShopCart shopCart)
        {
            _cartRep = cartRep;
            _shopCart = shopCart;
        }

        public IActionResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.ListShopItems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _cartRep.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}