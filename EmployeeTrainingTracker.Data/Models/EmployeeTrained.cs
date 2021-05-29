using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeTrainingTracker.Data.Models
{
    public class EmployeeTrained
    {
        [Key, Column(Order = 0)]
        public int EmployeeId { get; set; }
        [Key, Column(Order = 1)]
        public int TrainingId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("TrainingId")]
        public virtual Training Training { get; set; }
    }
}
