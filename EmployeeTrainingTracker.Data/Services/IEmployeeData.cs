using EmployeeTrainingTracker.Data.Models;
using System.Collections.Generic;

namespace EmployeeTrainingTracker.Data.Services
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
