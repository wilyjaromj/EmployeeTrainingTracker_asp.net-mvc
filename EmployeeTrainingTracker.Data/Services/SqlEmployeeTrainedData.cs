using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data.Services
{
    public class SqlEmployeeTrainedData : IEmployeeTrainedData
    {
        public string AddNewEmployeeTrained(EmployeeTrained record)
        {
            throw new NotImplementedException();
        }

        public string CreateExpectedAttendeesList(List<int> employeeIds)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeTrained> GetEmployeesWhoAttended(int trainingID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeTrained> GetEmployeesWhoDidNotAttendButShouldHave(int trainingID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeTrained> GetTrainingRoll(int trainingID)
        {
            throw new NotImplementedException();
        }
    }
}
