using DeltaCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DeltaCore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly DeltaWareDbContext _context;
        public ProductsController(ILogger<ProductsController> logger, DeltaWareDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            var allProducts = _context.Products.ToList();
            return View(allProducts);
        }

        public IActionResult CreateEditProduct()
        {
            return View();
        }

        public IActionResult CreateEditProductForm(Product model)
        {
            _context.Products.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Products");
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
