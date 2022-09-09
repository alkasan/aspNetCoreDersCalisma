using aspNetCoreDersCalisma.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace aspNetCoreDersCalisma.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hello my first app!";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName="Engin", LastName="Demirog",CityId=5},
                new Employee {Id = 2, FirstName = "Derin", LastName = "Demirog", CityId = 5},
                new Employee {Id = 3, FirstName = "Salih", LastName = "Demirog", CityId = 34}
        };
            List<string> cities = new List<string> { "İstanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employee = employees,
                Cities = cities,
            };
            return View(model);
        }

        public StatusCodeResult Index4()
        {
            return Ok();
        }

        public StatusCodeResult Index5()
        {
            return NotFound();
        }

        public RedirectResult Index6() 
        {
            return Redirect("/Home/Index3");
        }
        public IActionResult Index7()
        {
            return RedirectToAction("Index2");
        }

        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }

        public JsonResult Index9()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName="Engin", LastName="Demirog",CityId=5},
                new Employee {Id = 2, FirstName = "Derin", LastName = "Demirog", CityId = 5},
                new Employee {Id = 3, FirstName = "Salih", LastName = "Demirog", CityId = 34}
        };
            return Json(employees);
        }

        public IActionResult RazorDemo()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Id=1, FirstName="Engin", LastName="Demirog",CityId=5},
                new Employee {Id = 2, FirstName = "Derin", LastName = "Demirog", CityId = 5},
                new Employee {Id = 3, FirstName = "Salih", LastName = "Demirog", CityId = 34}
        };
            List<string> cities = new List<string> { "İstanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employee = employees,
                Cities = cities,
            };
            return View(model);
        }
    }
}
