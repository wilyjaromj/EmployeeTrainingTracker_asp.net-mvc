using EmployeeTrainingTracker.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeTrainingTracker.Data.Services
{
    public class SqlEmployeeData : IEmployeeData
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            using (var ctx = new EmployeeTrainingDB())
            {
                return ctx.Employees.ToList();
            }
        }
    }
}
