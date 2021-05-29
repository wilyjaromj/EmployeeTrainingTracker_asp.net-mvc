using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeTrainingTracker.Data.Models
{
    public class Training
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
}
