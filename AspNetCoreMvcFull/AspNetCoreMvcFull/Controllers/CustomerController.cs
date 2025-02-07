using AspNetCoreMvcFull.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvcFull.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> cList = new List<Customer>
        {
            new Customer{Id =1,Name = "Ali", Surname="Yıldırım",Age=25,Balance=90000},
            new Customer{Id =2,Name = "Yusuf", Surname="Atsız",Age=18,Balance=8000},
            new Customer{Id =3,Name = "Ayşe", Surname="Gül",Age=37,Balance=84000},

        };
        public IActionResult Index()
        {
            return View(cList);
        }
        public IActionResult NewCustomer()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult NewCustomer(IFormCollection f) // 2. Yöntem
        //{
        //    Customer c = new Customer();
        //    c.Name = f["Name"];
        //    c.Surname = f["Surname"];
        //    c.Age = int.Parse(f["Age"]);
        //    c.Balance = Convert.ToInt32(f["Balance"]);
        //    cList.Add(c);
        //    return RedirectToAction("Index");
        //}
        public IActionResult NewCustomer(Customer c) // Model Binding
        {
            cList.Add(c);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var customer = cList.Where(x => x.Id == id).FirstOrDefault();
            return View(customer);
        }
    }
}
