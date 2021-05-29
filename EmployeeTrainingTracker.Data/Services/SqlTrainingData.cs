using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public string DeleteTraining(int id)
        {
            try
            {
                // There may be employees marked as attending this training, have to clear them out first
                if (context.EmployeesTrained.Any(et => et.TrainingId == id))
                {
                    var employeesTrained = context.EmployeesTrained.Where(et => et.TrainingId == id)
                                                                                     .ToList();
                    context.EmployeesTrained.RemoveRange(employeesTrained);
                }

                context.Trainings.Remove(context.Trainings.Find(id));
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
                var original = context.Trainings.Find(training.Id);
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
