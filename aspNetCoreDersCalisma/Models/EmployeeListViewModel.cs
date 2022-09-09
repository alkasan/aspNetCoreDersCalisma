using aspNetCoreDersCalisma.Entities;
using System.Collections.Generic;

namespace aspNetCoreDersCalisma
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employee { get; set; }
        public List<string> Cities { get; set; }
    }
}