using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeTrainingTracker.Data.Services
{
    public class SqlEmployeeTrainedData : IEmployeeTrainedData
    {
        EmployeeTrainingDB context;

        public SqlEmployeeTrainedData()
        {
            context = new EmployeeTrainingDB();
        }

        public string AddNewEmployeeTrained(EmployeeTrained record)
        {
            try
            {
                context.EmployeesTrained.Add(record);
                context.SaveChanges();
                return "success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<EmployeeTrained> GetEmployeesWhoAttended(int trainingID)
        {
            return context.EmployeesTrained.Include("Employee")
                                           .Where(et => et.TrainingId == trainingID)
                                           .ToList();
        }
    }
}
