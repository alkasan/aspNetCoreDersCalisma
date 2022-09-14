using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspNetCoreDersCalisma.Entities;
using aspNetCoreDersCalisma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspNetCoreDersCalisma.Pages.Studentp
{
    public class IndexModel : PageModel
    {
        private readonly SchoolContext _context;

        public IndexModel(SchoolContext context)
        {
            _context = context;
        }
        public List<Student>Students { get; set; }  
        public void OnGet()
        {
            Students = _context.Students.ToList();
        }

        [BindProperty]
        public Student Student { get; set; }
        public IActionResult OnPost()
        {
            _context.Students.Add(Student);
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }

         
    }
}
