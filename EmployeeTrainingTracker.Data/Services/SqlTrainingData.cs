using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data.Services
{
    public class SqlTrainingData : ITrainingData
    {
        EmployeeTrainingDB context;

        public SqlTrainingData()
        {
            context = new EmployeeTrainingDB();
        }

        public string AddNewTraining(Training training)
        {
            try
            {
                context.Trainings.Add(training);
                context.SaveChanges();
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<Training> GetAllTrainings()
        {
            return context.Trainings.ToList();
        }

        public Training GetTrainingById(int id)
        {
            return context.Trainings.Find(id);
        }

        public string UpdateTraining(Training training)
        {
            try
            {
                Training original = context.Trainings.Find(training.Id);
                context.Entry(original).CurrentValues.SetValues(training);
                context.SaveChanges();
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
