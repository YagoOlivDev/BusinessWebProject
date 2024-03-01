using Microsoft.EntityFrameworkCore;
using ProjectWeb.Models;

namespace ProjectWeb.Data
{
    public class ProjectWebContext : DbContext
    {
        public ProjectWebContext (DbContextOptions<ProjectWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
