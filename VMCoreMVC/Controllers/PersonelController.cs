using Microsoft.AspNetCore.Mvc;
using VMCoreMVC.Models;
using VMCoreMVC.Models.Enums;
using VMCoreMVC.Models.VMs;

namespace VMCoreMVC.Controllers
{
    public class PersonelController : Controller
    {
        static List<Personel> personels = new List<Personel>()
        {
            new Personel(){ID = 1, Name = "Abdülsamet YILMAZ",BirthDate = new DateTime(1998,12,17),WorkingType=WorkingType.FullTime},
            new Personel(){ID = 2, Name = "Ali VELİ",BirthDate = new DateTime(2000,01,01),WorkingType=WorkingType.PartTime},
            new Personel(){ID = 3, Name = "Ayşe TÜRK",BirthDate = new DateTime(2002,04,08),WorkingType=WorkingType.ProjectBased},
        };
        List<Department> departments = new List<Department>()
        {
            new Department()
            {
                ID = 1,
                DepartmentName = "Yazılım"
            },
            new Department()
            {
                ID = 2,
                DepartmentName = "Muhasebe"
            },
            new Department()
            {
                ID = 3,
                DepartmentName = "Donamım"
            },
            new Department()
            {
                ID = 4,
                DepartmentName = "IT"
            },
            new Department()
            {
                ID = 5,
                DepartmentName = "IK"
            },

        };
        public IActionResult Index()
        {
            return View(personels);
        }

        public IActionResult Create()
        {
            CreateVM vM = new CreateVM();
            vM.Personel = new Personel();
            vM.Departments = departments;
            return View(vM);
        }
        [HttpPost]
        //Personel e Personel isim ataması yapma sebebimiz .cshtml sayfasında @Model.Personel.Id de ki .Personel adını yakalaması içindir.
        public IActionResult Create(Personel Personel)
        {
            personels.Add(Personel);
            return RedirectToAction("Index");
        }
    }
}
