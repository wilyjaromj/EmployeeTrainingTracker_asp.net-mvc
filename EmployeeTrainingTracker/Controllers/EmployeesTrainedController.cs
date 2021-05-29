using EmployeeTrainingTracker.Data.Models;
using EmployeeTrainingTracker.Data.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EmployeeTrainingTracker.Controllers
{
    public class EmployeesTrainedController : Controller
    {
        IEmployeeData employeeData;
        IEmployeeTrainedData employeeTrainedData;
        ITrainingData trainingData;

        public EmployeesTrainedController()
        {
            employeeData = new SqlEmployeeData();
            employeeTrainedData = new SqlEmployeeTrainedData();
            trainingData = new SqlTrainingData();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EmployeesTrained(int trainingId)
        {
            return View("_EmployeesTrainedTable", employeeTrainedData.GetEmployeesWhoAttended(trainingId));
        }

        [HttpGet]
        public ActionResult MarkEmployeeTrainedForm()
        {
            var employeesSelect = new List<SelectListItem>();
            var trainingsSelect = new List<SelectListItem>();

            foreach (var employee in employeeData.GetAllEmployees())
            {
                employeesSelect.Add(new SelectListItem
                {
                    Text = $"{employee.FirstName} {employee.LastName}",
                    Value = $"{employee.Id}"
                });
            }

            foreach (var training in trainingData.GetAllTrainings())
            {
                trainingsSelect.Add(new SelectListItem
                {
                    Text = training.Name,
                    Value = $"{training.Id}"
                });
            }

            ViewBag.Employees = employeesSelect;
            ViewBag.Trainings = trainingsSelect;

            return View("_MarkEmployeeTrainedForm");
        }

        [HttpPost]
        public ActionResult MarkEmployeeTrained(int employeeId, int trainingId)
        {
            if (employeeTrainedData.GetEmployeesWhoAttended(trainingId).Any(et => et.EmployeeId == employeeId))
            {
                return Json(new { status = "duplicate" });
            }

            var record = new EmployeeTrained
            {
                EmployeeId = employeeId,
                TrainingId = trainingId
            };

            var result = employeeTrainedData.AddNewEmployeeTrained(record);

            if (result == "success")
            {
                return Json(new { status = result });
            }
            else
            {
                return Json(new { status = "error", message = result });
            }
        }
    }
}