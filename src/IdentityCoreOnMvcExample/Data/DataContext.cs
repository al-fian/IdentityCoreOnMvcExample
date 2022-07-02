using IdentityCoreOnMvcExample.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityCoreOnMvcExample.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee>? Employees { get; set; }
    }
}
