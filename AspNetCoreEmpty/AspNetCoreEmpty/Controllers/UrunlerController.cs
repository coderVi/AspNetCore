using AspNetCoreEmpty.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class UrunlerController : Controller
    {
        List<Urunler> UrunlerList = new List<Urunler>();
        public IActionResult Index()
        {
            Urunler u = new Urunler();
            u.Id = 1;
            u.UrunAdi = "Kitap";
            u.UrunFiyat = 90;
            u.UrunAdet = 5;
            u.ToplamFiyat = u.UrunFiyat*u.UrunAdet;
            UrunlerList.Add(u);

            Urunler u1 = new Urunler();
            u1.Id = 2;
            u1.UrunAdi = "Defter";
            u1.UrunFiyat = 120;
            u1.UrunAdet = 7;
            u1.ToplamFiyat = u1.UrunFiyat * u1.UrunAdet;
            UrunlerList.Add(u1);

            Urunler u2 = new Urunler();
            u2.Id = 3;
            u2.UrunAdi = "Kalem";
            u2.UrunFiyat = 50;
            u2.UrunAdet = 18;
            u2.ToplamFiyat = u2.UrunFiyat * u2.UrunAdet;
            UrunlerList.Add(u2);
            return View(UrunlerList);
        }
    }
}
