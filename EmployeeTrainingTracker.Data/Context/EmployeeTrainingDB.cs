using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data.Context
{
    class EmployeeTrainingDB : DbContext
    {
        public EmployeeTrainingDB() : base() { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<EmployeeTrained> EmployeesTrained { get; set; }
    }
}
