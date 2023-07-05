using Microsoft.AspNetCore.Mvc;
using arpi.Models;
using arpi.Data; // Import the necessary data context namespace

namespace arpi.Pages.Controllers
{
    public class ProductsController : Controller
    {
        private readonly YourDataContext _context;

        public ProductsController(YourDataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();

            return View(products);
        }

        // Add more actions as per your wireframe requirements
    }
}
