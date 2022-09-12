using aspNetCoreDersCalisma.Entities;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;

namespace aspNetCoreDersCalisma.TagHelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper : TagHelper
    {
        private List<Employee> _employees; 
        public EmployeeListTagHelper()
        {
            _employees = new List<Employee>
            {
    
                new Employee{Id=1, FirstName="Engin", LastName="Demirog",CityId=6},
                new Employee {Id = 2, FirstName = "Derin", LastName = "Demirog", CityId = 3},
                new Employee {Id = 3, FirstName = "Salih", LastName = "Demirog", CityId = 34}
            };
        }
         override 
    }
}
