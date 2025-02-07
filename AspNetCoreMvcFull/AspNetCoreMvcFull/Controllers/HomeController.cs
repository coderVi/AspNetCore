using System.Diagnostics;
using AspNetCoreMvcFull.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFull.Controllers
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
            return View();
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            if (UserName == "Admin" && Password == "12345")
            {
                return RedirectToAction("Welcome","Home");
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Welcome()
        {
            return View();
        }

    }
}
