using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SkoolMgmt.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SkoolMgmt.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Title = "Dashboard | Admin";
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AdmitStudent(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationDbContext context = new ApplicationDbContext();
                ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
                var user = new ApplicationUser { UserName = model.UserName, Email = model.Email, Name = model.Name };
                var result = await manager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    manager.AddToRole(user.Id, "Student");
                    return View("Index");
                }
                AddErrors(result);
            }
            return View("Student",model);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        public ActionResult Settings()
        {
            return View();
        }
    }
}