using EmployeeTrainingTracker.Data.Models;
using EmployeeTrainingTracker.Data.Services;
using System;
using System.Web.Mvc;

namespace EmployeeTrainingTracker.Controllers
{
    public class TrainingController : Controller
    {
        ITrainingData trainingData;

        public TrainingController()
        {
            trainingData = new SqlTrainingData();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TrainingTable(bool forMarking = false)
        {
            ViewBag.ForMarking = forMarking;
            return View("_TrainingTable", trainingData.GetAllTrainings());
        }

        [HttpGet]
        public ActionResult AddEditModal(int id)
        {
            Training model;
            if (id <= 0)
            {
                model = new Training
                {
                    Date = DateTime.Today
                };
            }
            else
            {
                model = trainingData.GetTrainingById(id);
            }

            return View("_AddEditModal", model);
        }

        [HttpPost]
        public ActionResult SaveTraining(Training training)
        {
            string result;
            if (training.Id > 0)
            {
                result = trainingData.UpdateTraining(training);
            }
            else
            {
                result = trainingData.AddNewTraining(training);
            }

            if (result == "success")
            {
                return Json(new { status = result });
            }
            else
            {
                return Json(new { status = "error", message = result });
            }
        }

        [HttpPost]
        public ActionResult DeleteTraining(int idToDelete)
        {
            var result = trainingData.DeleteTraining(idToDelete);

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