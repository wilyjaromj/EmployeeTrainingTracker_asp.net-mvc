using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTrainingTracker.Data
{
    class EmployeeTrainingDB : DbContext
    {
        public EmployeeTrainingDB() : base("EmployeeTrainingDB") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<EmployeeTrained> EmployeesTrained { get; set; }
    }
}
