using HackathonBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace HackathonBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        //public DbSet<User> Users { get; set; }
        //public DbSet<EnergyCheck> EnergyChecks { get; set; }
        public DbSet<EnergyProfile> EnergyProfiles { get; set; }
        public DbSet<Appliance> Appliances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.EnergyCheck)
            //    .WithOne(ec => ec.User)
            //    .HasForeignKey(ec => ec.ResourceId); // Connect ResourceId to UserId

            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.EnergyProfiles)
            ////    .WithOne(ep => ep.UserInfo)
            //    .HasForeignKey(ep => ep.UserInfoId);

            modelBuilder.Entity<Appliance>()
                .HasMany(a => a.EnergyProfiles)
                .WithMany(ep => ep.Appliances)
                .UsingEntity<Dictionary<string, object>>(
                    "ApplianceEnergyProfile",
                    j => j.HasOne<EnergyProfile>().WithMany().HasForeignKey("EnergyProfileId"),
                    j => j.HasOne<Appliance>().WithMany().HasForeignKey("ApplianceId")
                );
        }
    }
}

