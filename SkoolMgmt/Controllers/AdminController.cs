using System.Web.Mvc;

namespace SkoolMgmt.Controllers
{
    [Authorize(Roles = "Admin")]
    [ValidateAntiForgeryToken]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Title = "Dashboard | Admin";
            return View();
        }
        
        public ActionResult Settings()
        {
            return View();
        }
    }
}