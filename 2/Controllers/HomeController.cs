using _2.Models; 
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "iPhone 14 pro", Description = "Опис iPhone", Price = 799, ImageUrl = "iphone14pro.jpg" },
                new Product { Id = 2, Name = "MacBook Air M2", Description = "Опис MacBook", Price = 1299, ImageUrl = "macbookairm2.jpg" },
                new Product { Id = 3, Name = "iPad Pro M2 2022", Description = "Опис iPad", Price = 499, ImageUrl = "iPad-Pro-M2-2022-12-9-spacegray-photo.jpg" }
            };

            return View(products);
        }
    }
}
