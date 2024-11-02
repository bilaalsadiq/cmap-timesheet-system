using Microsoft.EntityFrameworkCore;
using cmap_timesheet_system.Models;

namespace cmap_timesheet_system.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TimesheetEntry> TimesheetEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TimesheetEntry>()
                .HasKey(te => te.id);
        }
    }
}
