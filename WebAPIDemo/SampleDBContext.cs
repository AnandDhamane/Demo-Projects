using Microsoft.EntityFrameworkCore;
using WebAPIDemo.Models;

namespace WebAPIDemo
{
    public class SampleDBContext : DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}
