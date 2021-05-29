using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
