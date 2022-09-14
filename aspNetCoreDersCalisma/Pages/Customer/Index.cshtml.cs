using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace aspNetCoreDersCalisma.Pages.Customer
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
            Message += "Date is" + DateTime.Now.ToString();
        }
    }
}
