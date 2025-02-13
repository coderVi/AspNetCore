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
                ViewBag.Mesaj = "Kullanýcý adý veya Þifre Hatalý. Tekrar deneyin";
                return View();
            }
            
        }
        public IActionResult Welcome()
        {
            return View();
        }
        public IActionResult BirdenFazlaModel()
        {
            var book = new List<Book>
            {
                new Book {BookName="Kitap 1"},
                new Book {BookName="Kitap 2"},
                new Book {BookName="Kitap 3"}
            };
            var customer = new List<Customer>
            {
                new Customer {Name = "Ali"},
                new Customer {Name = "Veli"},
                new Customer {Name = "Cem"},
            };

            var vm = new CustomerBookVM
            {
                Books = book,
                Customers = customer,
            };

            return View(vm);
        }

    }
}
