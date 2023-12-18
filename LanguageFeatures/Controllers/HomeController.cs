using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            string[] namesarr = new string[3];
            namesarr[0] = "Louie";
            namesarr[1] = "Phoebe";
            namesarr[2] = "Ro";


            object[] data = new object[] { 24M, 29.5M, "apple", "orange", 10, 100 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }


            return View("Index", new string[] { $"Total:{total:C2}" });
        }
    }
}