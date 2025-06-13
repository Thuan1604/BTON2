using BTON2.Models;
using Microsoft.EntityFrameworkCore;
using BTON2.Models;

namespace BTON2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Device> Devices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<ViewServiceAssignStat> ViewServiceAssignStats { get; set; }
        public DbSet<ViewAssignUsedStat> ViewAssignUsedStats { get; set; }
        public DbSet<ViewDeviceAssignStat> ViewDeviceAssignStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ViewServiceAssignStat>().HasNoKey().ToView("view_service_assign_stats");
            modelBuilder.Entity<ViewAssignUsedStat>().HasNoKey().ToView("view_assign_used_stats");
            modelBuilder.Entity<ViewDeviceAssignStat>().HasNoKey().ToView("view_device_assign_stats");
        }
    }
}
