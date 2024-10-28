using Microsoft.AspNetCore.Mvc;
using Project_BookShop.Models;
using System.Diagnostics;

namespace Project_BookShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // Constructor that initializes the logger
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Action method for the default Home page
        public IActionResult Index()
        {
            return View();
        }

        // Action method for the Privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Action method for handling errors; it passes an error model to the view
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
