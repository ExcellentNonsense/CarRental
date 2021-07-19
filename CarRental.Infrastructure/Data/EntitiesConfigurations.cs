using CarRental.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace CarRental.Infrastructure.Data
{
    class CarConfig : EntityTypeConfiguration<Car>
    {
        public CarConfig()
        {
            HasRequired(x => x.Model);
            HasRequired(x => x.Location);

            Property(x => x.RegistrationNumber).IsRequired().HasMaxLength(20);
        }
    }

    class CarBrandConfig : EntityTypeConfiguration<CarBrand>
    {
        public CarBrandConfig()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(40);
        }
    }
    
    class CarModelConfig : EntityTypeConfiguration<CarModel>
    {
        public CarModelConfig()
        {
            HasRequired(x => x.Brand);
            HasRequired(x => x.Type);

            Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }

    class CityConfig : EntityTypeConfiguration<City>
    {
        public CityConfig()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(50);
        }
    }

    class LocationConfig : EntityTypeConfiguration<Location>
    {
        public LocationConfig()
        {
            HasRequired(x => x.City);

            Property(x => x.Name).IsRequired().HasMaxLength(250);
        }
    }

    class OrderConfig : EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            HasRequired(x => x.Renter);
            HasRequired(x => x.Item);
        }
    }

    class PriceListItemConfig : EntityTypeConfiguration<PriceListItem>
    {
        public PriceListItemConfig()
        {
            HasRequired(x => x.Car);
        }
    }

    class RenterConfig : EntityTypeConfiguration<Renter>
    {
        public RenterConfig()
        {
            HasRequired(x => x.Passport)
                .WithRequiredPrincipal(x => x.Renter)
                .WillCascadeOnDelete(true);

            Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            Property(x => x.LastName).IsRequired().HasMaxLength(100);
            Property(x => x.Email).IsRequired();
            Property(x => x.PhoneNumber).IsRequired().HasMaxLength(10);
            Ignore(x => x.FullName);
        }
    }

    class RenterPassportConfig : EntityTypeConfiguration<RenterPassport>
    {
        public RenterPassportConfig()
        {
            Property(x => x.Number).IsRequired().HasMaxLength(9).IsConcurrencyToken();
            Property(x => x.BirthDate).IsRequired();
        }
    }

    class VehicleTypeConfig : EntityTypeConfiguration<VehicleType>
    {
        public VehicleTypeConfig()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(40);
        }
    }
}
