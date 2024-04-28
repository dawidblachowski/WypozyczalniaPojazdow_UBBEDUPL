using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Wypoz_ASP.Models.Database;

namespace Wypoz_ASP.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<RentalPoint> RentalPoints { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rental>()
                .HasOne(v=> v.Vehicle)
                .WithMany(r => r.Rentals)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Rental>()
                .HasOne(u => u.User)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reservation>()
                .HasOne(u => u.User)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);



        }

    }
}
