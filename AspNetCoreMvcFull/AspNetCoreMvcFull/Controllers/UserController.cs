using AspNetCoreMvcFull.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFull.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //HTML HELPERS => MVC de vardı

        //TAG HELPERS => Core ile gelen

        public IActionResult HtmlHelpers() => View();

        [HttpPost]
        public IActionResult HtmlHelpers(User u)
        {
            return View("TagHelpers");
        }

        public IActionResult TagHelpers()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TagHelpers(User u)
        {
            return View("HtmlHelpers");
        }
    }
}
