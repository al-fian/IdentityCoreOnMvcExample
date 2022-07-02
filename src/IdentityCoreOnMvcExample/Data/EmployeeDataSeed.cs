using IdentityCoreOnMvcExample.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityCoreOnMvcExample.Data
{
    public class EmployeeDataSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new DataContext(
                serviceProvider.GetRequiredService<DbContextOptions<DataContext>>());

            context.Database.EnsureCreated();

            if (context == null || context.Employees == null)
            {
                throw new ArgumentNullException("Null DataContext");
            }

            if (context.Employees.Any())
            {
                return;
            }

            context.Employees.AddRange(
                new Employee
                {
                    Id = new Guid("e310a6cb-6677-4aa6-93c7-2763956f7a97"),
                    Name = "Mark Miens",
                    Age = 26,
                    Position = "Software Developer"
                },
                new Employee
                {
                    Id = new Guid("398d10fe-4b8d-4606-8e9c-bd2c78d4e001"),
                    Name = "Anna Simmons",
                    Age = 29,
                    Position = "Software Developer"
                }
            );

            context.SaveChanges();
        }
    }
}
