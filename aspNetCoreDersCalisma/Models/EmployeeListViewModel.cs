using aspNetCoreDersCalisma.Entities;
using System.Collections.Generic;

namespace aspNetCoreDersCalisma.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public List<string> Cities { get; set; }
    }
}    