using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ShoppingCart cart = new ShoppingCart
            {
                Products = Product.GetProducts()
            };
            Product[] productArray =
            {
                new Product{Name= "MyNewKayak",Price = 20.40M},
                new Product{Name= "MyNewBoat", Price = 30.44M},
                new Product{Name= "RainJacket", Price = 10.00M},
                new Product{Name= "MyNewBoat", Price = 20.44M},
            };
            decimal cartTotal = cart.TotalPrices();
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

            decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            decimal nameFilterTotal = productArray.Filter(p => (p?.Name?[0] == 'S')).TotalPrices();

            return View("Index", new string[]
            {
                $"Cart total : {cartTotal:C2}",
                $"Array Total: {arrayTotal:C2}",
                $"Price Total: {priceFilterTotal:C2}",
                $"name Total: {nameFilterTotal:C2}",
            });
        }
    }
}