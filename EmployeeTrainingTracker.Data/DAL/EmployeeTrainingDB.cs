using EmployeeTrainingTracker.Data.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EmployeeTrainingTracker.Data
{
    class EmployeeTrainingDB : DbContext
    {
        public EmployeeTrainingDB() : base("name=EmployeeTrainingDB") {
            Database.SetInitializer(new DBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<EmployeeTrained> EmployeesTrained { get; set; }
    }
}
