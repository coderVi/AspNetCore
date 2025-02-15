using System.Diagnostics;
using AspQuiz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AspQuiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        static List<Urun> uruns = new List<Urun>();
        static List<User> users = new List<User>()
        {
            new User
            {
                UserID = 1,
                UserName = "John",
                UserLastName = "Doe"
            }

        };
        public IActionResult Index()
        {
            var user = users.FirstOrDefault(); // users listesinden ilk kullanýcýyý al

            ViewBag.Id = user.UserID;
            ViewBag.Ad = user.UserName;
            ViewBag.Soyad = user.UserLastName;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Privacy(IFormCollection f)
        {
            Urun urun = new Urun
            {
                UrunId = Convert.ToInt32(f["UrunId"]),
                UrunAdi = f["UrunAdi"],
                UrunFiyat = Convert.ToDecimal(f["UrunFiyat"]),
                UrunStokAdet = Convert.ToInt32(f["UrunStokAdet"])
            };
            uruns.Add(urun);
            return RedirectToAction("Yazdir");
        }

        public IActionResult Yazdir()
        {
            ViewData["ToplamUrunAdedi"] = uruns.Count;
            ViewData["ToplamUrunFiyati"] = uruns.Sum(u => u.UrunFiyat);
            ViewData["ToplamStokAdedi"] = uruns.Sum(u => u.UrunStokAdet);

            return View(uruns);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Urun urun)
        {
            if (ModelState.IsValid)
            {
                uruns.Add(urun);
                return RedirectToAction("Yazdir");
            }
            return View(urun);
        }
        // 4 . Soru = 3. Sorudaki view ekranýnda tabloya bir sutun daha ekleyip Ekle, Güncelle ve Sil Butonlarý yerleþtiriniz. 
        // Ekle butonu anlaþýlmadýðýndan dolayý yapýlmadý. Urun ekle ise zaten var hayýr güncelleme ise yapýldý zaten.

        public IActionResult Delete(int id)
        {
            var urun = uruns.FirstOrDefault(x => x.UrunId == id);
            if (urun != null)
            {
                uruns.Remove(urun);
            }
            return RedirectToAction("Yazdir",uruns);
        }
        public IActionResult Update(int id)
        {
            var urun = uruns.FirstOrDefault(x => x.UrunId == id);
            return View(urun);
        }
        [HttpPost]
        public IActionResult Update(Urun urun)
        {
            var UpdateUrun = uruns.FirstOrDefault(x => x.UrunId == urun.UrunId);
            UpdateUrun.UrunId = urun.UrunId;
            UpdateUrun.UrunAdi = urun.UrunAdi;
            UpdateUrun.UrunFiyat = urun.UrunFiyat;
            UpdateUrun.UrunStokAdet = urun.UrunStokAdet;
            return RedirectToAction("Yazdir");
        }
        public IActionResult Listele()
        {
            UserUrunVM totals = new UserUrunVM()
            {
                Uruns = uruns,
                Users = users
            };

            return View(totals);
        }

    }
}
