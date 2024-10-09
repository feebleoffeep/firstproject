using _2.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

public class BuyController : Controller
{
    private readonly ApplicationDbContext _context;

    public BuyController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var cart = GetCart();
        return View(cart);
    }

    public IActionResult AddToCart(int productId)
    {
        var product = _context.Products.FirstOrDefault(p => p.Id == productId);
        if (product != null)
        {
            var cart = GetCart();
            cart.AddItem(product, 1);
            SaveCart(cart);
        }
        return RedirectToAction("Index");
    }

    private Cart GetCart()
    {
        var cart = HttpContext.Session.Get<Cart>("Cart") ?? new Cart();
        return cart;
    }

    private void SaveCart(Cart cart)
    {
        HttpContext.Session.Set("Cart", cart);
    }
}



