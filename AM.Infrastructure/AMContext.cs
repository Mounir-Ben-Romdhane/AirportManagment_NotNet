using AM.ApplicationCore.Domain;
using AM.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;


namespace AM.Infrastructure
{
    public class AMContext : DbContext
    {
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=airportManagmentDb;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassangerConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("datetime2");
        }
    }
}
