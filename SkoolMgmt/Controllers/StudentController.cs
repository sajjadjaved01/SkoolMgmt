using System.Web.Mvc;

namespace SkoolMgmt.Controllers
{
    [Authorize(Roles = "Student")]
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}