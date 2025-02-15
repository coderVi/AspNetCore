using CoreTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreTemplate.Controllers
{
    public class EgitimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Apply(Ogrenci ogr)
        {
            if (ModelState.IsValid)
            {
                Repository.OgrenciEkle(ogr);
                return View("Tesekkurler", ogr);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ListeKatilanlar()
        {
            var liste = Repository.ogrenciListe().Where(x => x.Katilim == true).ToList();
            return View(liste);
        }

        public IActionResult ListeKatilmayanlar()
        {
            var liste = Repository.ogrenciListe().Where(x => x.Katilim == false).ToList();
            return View(liste);
        }
    }
}
