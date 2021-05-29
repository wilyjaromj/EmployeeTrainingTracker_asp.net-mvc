using EmployeeTrainingTracker.Data.Services;
using System.Web.Mvc;

namespace EmployeeTrainingTracker.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeData employeeData;

        public EmployeeController()
        {
            employeeData = new SqlEmployeeData();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(employeeData.GetAllEmployees());
        }
    }
}