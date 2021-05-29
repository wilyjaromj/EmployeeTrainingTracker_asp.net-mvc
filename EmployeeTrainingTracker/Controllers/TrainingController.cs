using EmployeeTrainingTracker.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeTrainingTracker.Controllers
{
    public class TrainingController : Controller
    {
        ITrainingData trainingData;

        public TrainingController()
        {
            
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}