using Microsoft.EntityFrameworkCore;
using MilesCarRental.Entities;

namespace MilesCarRental.Repository.EFCore
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Bookings> Bookings { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-N5GB4D9\SQLEXPRESS; Database=MilesCarRentalPru;Trusted_Connection=true;TrustServerCertificate=true");
        //}
    }
}
