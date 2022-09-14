using aspNetCoreDersCalisma.Entities;
using aspNetCoreDersCalisma.Models;
using aspNetCoreDersCalisma.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace aspNetCoreDersCalisma.Controllers
{
    public class EmployeeController : Controller
    {
        private ICalculator _calculator;
        private ICalculator _calculator2;

        public EmployeeController(ICalculator calculator, ICalculator calculator2)
        {
            _calculator = calculator;
            _calculator2 = calculator2; 
        }

            public IActionResult Add()
        {
            var employeeAddViewModel = new EmpployeeAddViewModel
            {
                Employees = new Employee(),
                Cities = new List<SelectListItem>
                {
                    new SelectListItem { Text = "Ankara", Value = "6" },
                    new SelectListItem { Text = "İstanbul", Value = "34" }
                }
            };
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return View();
        }

        public string Calculate()
        {
            _calculator2.Calculate(1000);
            return _calculator.Calculate(100).ToString();
        }
    }
}
