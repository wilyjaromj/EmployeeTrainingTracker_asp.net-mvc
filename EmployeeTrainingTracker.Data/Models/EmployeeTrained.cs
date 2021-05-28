using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data.Models
{
    public class EmployeeTrained
    {
        [Key, Column(Order = 0)]
        public int EmployeeId { get; set; }
        [Key, Column(Order = 1)]
        public int TrainingId { get; set; }
        public bool Attended { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("TrainingId")]
        public virtual Training Training { get; set; }
    }
}
