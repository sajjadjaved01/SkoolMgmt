using System.Web.Mvc;

namespace SkoolMgmt.Controllers
{
    [Authorize(Roles = "Teachers")]
    public class TeachersController : Controller
    {
        // GET: Teachers
        public ActionResult Index()
        {
            return View();
        }
    }
}