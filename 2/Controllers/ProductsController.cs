using Microsoft.AspNetCore.Mvc;
namespace _2.Models;
using System.Collections.Generic;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "iPhone 14", Price = 50000, Description = "Новий iPhone 14", ImageUrl = "/images/iphone14.png" },
            new Product { Id = 2, Name = "MacBook Pro", Price = 80000, Description = "MacBook Pro 16''", ImageUrl = "/images/macbookpro.png" },
            new Product { Id = 3, Name = "Apple Watch", Price = 15000, Description = "Apple Watch Series 8", ImageUrl = "/images/applewatch.png" }
        };

        return View(products); 
    }
}



