using System.Web.Mvc;

namespace EmployeeTrainingTracker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}