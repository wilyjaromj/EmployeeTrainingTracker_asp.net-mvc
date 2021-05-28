using EmployeeTrainingTracker.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data.Services
{
    public interface IEmployeeTrainedData
    {
        IEnumerable<EmployeeTrained> GetTrainingRoll(int trainingID);
        IEnumerable<EmployeeTrained> GetEmployeesWhoAttended(int trainingID);        
        IEnumerable<EmployeeTrained> GetEmployeesWhoDidNotAttendButShouldHave(int trainingID);
    }
}
