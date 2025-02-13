using AspNetCoreMvcFull.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFull.Controllers
{
    public class SiparisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UrunSat()
        {

            return View();
        }
        [HttpPost]
        public IActionResult UrunSat(IFormCollection f)
        {
            TempData["satilanId"] = Convert.ToInt32(f["UrunId"]);
            TempData["satilanAdi"] = f["UrunAdi"].ToString();
            TempData["satilanFiyati"] = Convert.ToInt32(f["UrunFiyati"]);

            return RedirectToAction("StokAzalt", "Urun");
        }
        public IActionResult UrunSatModel()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UrunSatModel(Product p)
        {
            //return View("Sonuc",p); //Farklı bir view a model gönderme
            return RedirectToAction("UrunModelAl", p);
        }
        public IActionResult UrunModelAl(Product p)
        {
            return View(p);
        }
    }
}
