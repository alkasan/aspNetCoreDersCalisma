using aspNetCoreDersCalisma.Filters;
using Microsoft.AspNetCore.Mvc;

namespace aspNetCoreDersCalisma.Controllers
{
    public class FilterController : Controller
    {
        [CustomFilter]
        public IActionResult Index()
        {
            return View();
        }
    }
}
