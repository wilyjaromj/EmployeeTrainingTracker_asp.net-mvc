using EmployeeTrainingTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EmployeeTrainingTracker.Data
{
    class DBInitializer : DropCreateDatabaseIfModelChanges<EmployeeTrainingDB>
    {
        protected override void Seed(EmployeeTrainingDB context)
        {
            var employees = new List<Employee>
            {
                new Employee { FirstName = "James", LastName = "Kirk" },
                new Employee { FirstName = "Mr", LastName = "Spock" },
                new Employee { FirstName = "Leonard", LastName = "McCoy" },
                new Employee { FirstName = "Montgomery", LastName = "Scott" },
                new Employee { FirstName = "Hikaru", LastName = "Sulu" }
            };

            context.Employees.AddRange(employees);

            var trainings = new List<Training>
            {
                new Training { Name = "Navigation", Date = new DateTime (2021, 01, 10) },
                new Training { Name = "Warp Drive Maintenance", Date = new DateTime (2021, 02, 16) },
                new Training { Name = "Transporter Safety", Date = new DateTime (2021, 03, 05) },
                new Training { Name = "Phaser Qualification", Date = new DateTime (2021, 04, 29) },
                new Training { Name = "First Contact Procedures", Date = new DateTime (2021, 05, 17) },
                new Training { Name = "Inter Species Communication", Date = new DateTime (2021, 06, 24) }
            };

            context.Trainings.AddRange(trainings);

            context.SaveChanges();

            var employeesTrained = new List<EmployeeTrained>
            {
                new EmployeeTrained { EmployeeId = 1, TrainingId = 1 },
                new EmployeeTrained { EmployeeId = 1, TrainingId = 2 },
                new EmployeeTrained { EmployeeId = 1, TrainingId = 3 },
                new EmployeeTrained { EmployeeId = 1, TrainingId = 4 },
                new EmployeeTrained { EmployeeId = 1, TrainingId = 5 },
                new EmployeeTrained { EmployeeId = 1, TrainingId = 6 },
                new EmployeeTrained { EmployeeId = 2, TrainingId = 1 },
                new EmployeeTrained { EmployeeId = 2, TrainingId = 2 },
                new EmployeeTrained { EmployeeId = 2, TrainingId = 4 },
                new EmployeeTrained { EmployeeId = 2, TrainingId = 5 },
                new EmployeeTrained { EmployeeId = 2, TrainingId = 6 },
                new EmployeeTrained { EmployeeId = 3, TrainingId = 3 },
                new EmployeeTrained { EmployeeId = 3, TrainingId = 5 },
                new EmployeeTrained { EmployeeId = 3, TrainingId = 6 },
                new EmployeeTrained { EmployeeId = 4, TrainingId = 2 },
                new EmployeeTrained { EmployeeId = 4, TrainingId = 3 },
                new EmployeeTrained { EmployeeId = 4, TrainingId = 4 },
                new EmployeeTrained { EmployeeId = 5, TrainingId = 2 },
                new EmployeeTrained { EmployeeId = 5, TrainingId = 3 },
                new EmployeeTrained { EmployeeId = 5, TrainingId = 4 },
                new EmployeeTrained { EmployeeId = 5, TrainingId = 5 }
            };

            context.EmployeesTrained.AddRange(employeesTrained);

            context.SaveChanges();
        }
    }
}
