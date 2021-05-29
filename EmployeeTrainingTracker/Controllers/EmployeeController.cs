using EmployeeTrainingTracker.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        public ActionResult Index()
        {
            return View(employeeData.GetAllEmployees());
        }
    }
}