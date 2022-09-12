using aspNetCoreDersCalisma.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace aspNetCoreDersCalisma.Models
{
    public class EmpployeeAddViewModel
    {
        public Employee Employees { get; set; }
        public List<SelectListItem> Cities { get;  set; }
    }
}

