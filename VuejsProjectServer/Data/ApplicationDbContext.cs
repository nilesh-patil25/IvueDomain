using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VuejsProjectServer.Models;

namespace VuejsProjectServer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
