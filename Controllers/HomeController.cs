using MetalUniverse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MetalUniverse.Data;

namespace MetalUniverse.Controllers
{
    
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var lastThreeProducts = _context.Products
                .OrderByDescending(p => p.ProductID)
                .Take(3)
                .ToList();

            return View(lastThreeProducts);
        }
    }


 /*
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }  
    } */ 
}
