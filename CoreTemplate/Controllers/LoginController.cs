using CoreTemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreTemplate.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Kullanici f)
        {
            if (f.username == "Admin" && f.password == "12345")
            {
                return RedirectToAction("Index","Home",f);
            }
            else
            {
                ViewBag.Mesaj = "Kullanıcı adı veya şifre hatalı";
                return View();
            }
        }
    }
}
