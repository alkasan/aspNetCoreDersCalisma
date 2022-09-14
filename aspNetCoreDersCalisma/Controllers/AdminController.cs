using Microsoft.AspNetCore.Mvc;

namespace aspNetCoreDersCalisma.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        [Route("")]
        [Route("save")]
        [Route("~/save")]
        public string Save()
        {
            return "Saved";
        }
        [Route("delete/{id?}")]
        public string Delete(int id=0)
        {
            return string.Format("Deleted {0}", id);
        }
        [Route("update")]
        public string Update()
        {
            return "Updated";
        }
    }
}
