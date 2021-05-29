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
        public Training AddNewTraining(Training training)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Training> GetAllTrainings()
        {
            using (var ctx = new EmployeeTrainingDB())
            {
                return ctx.Trainings.ToList();
            }
        }
    }
}
