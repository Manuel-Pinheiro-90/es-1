using es_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace es_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

           List<Product> menu = new List<Product>
        {
            new Product { Id = 1, Name = "Coca Cola 150 ml", Price = 2.50 },
            new Product { Id = 2, Name = "Insalata di pollo", Price = 5.20 },
            new Product { Id = 3, Name = "Pizza Margherita", Price = 10.00 },
            new Product { Id = 4, Name = "Pizza 4 Formaggi", Price = 12.50 },
            new Product { Id = 5, Name = "Pz patatine fritte", Price = 3.50 },
            new Product { Id = 6, Name = "Insalata di riso", Price = 8.00 },
            new Product { Id = 7, Name = "Frutta di stagione", Price = 5.00 },
            new Product { Id = 8, Name = "Pizza fritta", Price = 5.00 },
            new Product { Id = 9, Name = "Piadina vegetariana", Price = 6.00 },
            new Product { Id = 10, Name = "Panino Hamburger", Price = 7.90 }
        };
           
        
        return View(menu);
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
