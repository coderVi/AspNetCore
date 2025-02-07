using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductSales.Models;

namespace ProductSales.Controllers
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

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult SignUp(Users u)
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users u)
        {

            if (u.UserName == "Coder Vi" && u.Password == "12345")
            {
                return RedirectToAction("AdminPage", "Home");
            }
            else
            {
                return View();
            }

        }

        public IActionResult AdminPage()
        {
            return View();
        }
    }
}
