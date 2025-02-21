using System.Diagnostics;
using AspNetCoreDBFirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreDBFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        NorthwindContext db = new NorthwindContext();
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
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
