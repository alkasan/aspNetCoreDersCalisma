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
            return View(employees);
        }
    }
}
