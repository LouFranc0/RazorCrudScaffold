using Microsoft.EntityFrameworkCore;
using RazorCrudScaffold.Model;

namespace RazorCrudScaffold.DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) :
            base(options)
        { }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
