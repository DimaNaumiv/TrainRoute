using Microsoft.EntityFrameworkCore;
using Models;

namespace Train_Route.DAL
{
    public class AppDbContext:DbContext
    {
        public DbSet<Station> Stations { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<RouteStation> RouteStations { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TrainRouteDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
