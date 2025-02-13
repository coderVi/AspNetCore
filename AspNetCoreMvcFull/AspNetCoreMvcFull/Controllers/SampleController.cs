using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFull.Controllers
{
    public class SampleController : Controller
    {
        //this controller for View Bag, View Data and Temp Data
        public IActionResult Index()
        {
            ViewBag.Tarih = DateTime.Now.ToLongDateString();
            ViewBag.koleksiyon = new string[] { "Bu", "Bir", "Dizi" };

            ViewData["Saat"] = DateTime.Now.ToLongTimeString();

            TempData["Fiyat"] = 2500; //Home/privacy

            return View();
        }
    }
}
