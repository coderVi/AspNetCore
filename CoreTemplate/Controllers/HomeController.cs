using System.Diagnostics;
using CoreTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Kullanici f)
        {
            if (f.username == "Admin" && f.password == "12345")
            {
                return View();  

            }
            else
            {
                return RedirectToAction("Login","Login");
            }
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
