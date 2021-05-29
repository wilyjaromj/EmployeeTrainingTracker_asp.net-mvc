using EmployeeTrainingTracker.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data.Services
{
    public interface ITrainingData
    {
        IEnumerable<Training> GetAllTrainings();
        Training GetTrainingById(int id);
        string AddNewTraining(Training training);
        string UpdateTraining(Training training);
        string DeleteTraining(int id);
    }
}
