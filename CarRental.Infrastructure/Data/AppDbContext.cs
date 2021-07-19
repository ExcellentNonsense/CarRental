using CarRental.Domain.Entities;
using System.Data.Entity;

namespace CarRental.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DbConnection") { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PriceListItem> PriceListItems { get; set; }
        public DbSet<Renter> Renters { get; set; }
        public DbSet<RenterPassport> RenterPassports { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CarConfig());
            modelBuilder.Configurations.Add(new CarBrandConfig());
            modelBuilder.Configurations.Add(new CarModelConfig());
            modelBuilder.Configurations.Add(new CityConfig());
            modelBuilder.Configurations.Add(new LocationConfig());
            modelBuilder.Configurations.Add(new OrderConfig());
            modelBuilder.Configurations.Add(new PriceListItemConfig());
            modelBuilder.Configurations.Add(new RenterConfig());
            modelBuilder.Configurations.Add(new RenterPassportConfig());
            modelBuilder.Configurations.Add(new VehicleTypeConfig());
        }
    }
}
