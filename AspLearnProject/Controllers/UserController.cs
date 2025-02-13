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
        public IActionResult SignUp(User user)
        {
            if (user != null)
            {
                user.Name = Request.Form["Name"];
                if (string.IsNullOrEmpty(Request.Form["Name"]))
                {
                    throw new Exception("Name side is Null or Empty");
                }
                user.Surname = Request.Form["Surname"];
                if (string.IsNullOrEmpty(Request.Form["Name"]))
                {
                    throw new Exception("Surname side is Null or Empty");
                }
                user.Username = Request.Form["Username"];
                if (string.IsNullOrEmpty(Request.Form["Username"]))
                {
                    throw new Exception("Username side is Null or Empty");
                }
                user.Email = Request.Form["Email"];
                if (string.IsNullOrEmpty(Request.Form["Email"]))
                {
                    throw new Exception("Email side is Null or Empty");
                }
                user.Password = Request.Form["Password"];
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
