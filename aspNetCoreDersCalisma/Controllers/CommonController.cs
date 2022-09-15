using Microsoft.AspNetCore.Mvc;

namespace aspNetCoreDersCalisma.Controllers
{
    public class CommonController : Controller
    {
        [Route("/error")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
