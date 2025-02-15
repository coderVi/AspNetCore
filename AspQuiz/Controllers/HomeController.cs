using System.Diagnostics;
using AspQuiz.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspQuiz.Controllers
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
            var user = new User
            {
                UserID = 1,
                UserName = "John",
                UserLastName = "Doe"
            };

            ViewBag.Id = user.UserID;
            ViewBag.Ad = user.UserName;
            ViewBag.Soyad = user.UserLastName;

            return View();
        }
        [HttpPost]
        public IActionResult Urun(IFormCollection f)
        {
            Urun urun = new Urun()
            {
                UrunId = Convert.ToInt32(f["UrunId"]),
                UrunAdi = f["UrunAdi"],
                UrunFiyat = Convert.ToDecimal(f["UrunFiyat"]),
                UrunStokAdet = Convert.ToInt32(f["UrunStokAdet"])
            };

            return RedirectToAction("Privacy", urun);
        }

        public IActionResult Privacy(Urun urun)
        {
            return View(urun);
        }
    }
}
