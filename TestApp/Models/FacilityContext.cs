using Microsoft.EntityFrameworkCore;

namespace TestApp.Models
{
    public class FacilityContext : DbContext
    {
        public DbSet<Facility> Facilities { get; set; }

        public DbSet<FacilityStatus> FacilityStatuses { get; set; }

        public DbSet<FacilityLog> FacilityLogs { get; set; }

        public FacilityContext(DbContextOptions<FacilityContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
