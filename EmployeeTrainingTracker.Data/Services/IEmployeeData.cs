using EmployeeTrainingTracker.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data.Services
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAllEmployees();
    }
}
