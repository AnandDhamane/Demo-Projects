using BusinessModels;
using Microsoft.EntityFrameworkCore;

namespace WebAPIASyncDemo
{
    public class SampleDBContext : DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Industry> Industry { get; set; }
        public DbSet<IndustryContactPersons> IndustryContactPersons { get; set; }
        public DbSet<IndustryLocations> IndustryLocations { get; set; }
    }
}
