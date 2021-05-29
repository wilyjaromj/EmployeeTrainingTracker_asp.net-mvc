using EmployeeTrainingTracker.Data.Models;
using System.Collections.Generic;

namespace EmployeeTrainingTracker.Data.Services
{
    public interface IEmployeeTrainedData
    {
        IEnumerable<EmployeeTrained> GetEmployeesWhoAttended(int trainingID);
        string AddNewEmployeeTrained(EmployeeTrained record);
    }
}
