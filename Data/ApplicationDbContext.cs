using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartHome.Entities;

namespace SmartHome.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Sensor> Sensors { get; set; }

        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .IsRequired();


            modelBuilder.Entity<Role>()
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Sensor>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(25);

            base.OnModelCreating(modelBuilder);

        }
    }
}