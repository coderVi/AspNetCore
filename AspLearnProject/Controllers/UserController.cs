using AspLearnProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspLearnProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        //public IActionResult SignUp(User user)
        //{
        //    return RedirectToAction("Index", "Home");
        //}
    }
}
