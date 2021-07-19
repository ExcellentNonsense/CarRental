using CarRental.Domain.Interfaces.Repositories;

namespace CarRental.Infrastructure.Data.Repositories
{
    public class RepoUnitOfWork : IRepoUnitOfWork
    {
        private readonly AppDbContext _ctx;

        public RepoUnitOfWork(AppDbContext context)
        {
            _ctx = context;

            CarBrands = new CarBrandRepo(_ctx);
            CarModels = new CarModelRepo(_ctx);
            Cars = new CarRepo(_ctx);
            Cities = new CityRepo(_ctx);
            Locations = new LocationRepo(_ctx);
            Orders = new OrderRepo(_ctx);
            PriceListItems = new PriceListItemRepo(_ctx);
            Renters = new RenterRepo(_ctx);
            RenterPassports = new RenterPassportRepo(_ctx);
            VehicleTypes = new VehicleTypeRepo(_ctx);
        }

        public ICarBrandRepo CarBrands { get; private set; }

        public ICarModelRepo CarModels { get; private set; }

        public ICarRepo Cars { get; private set; }

        public ICityRepo Cities { get; private set; }

        public ILocationRepo Locations { get; private set; }

        public IOrderRepo Orders { get; private set; }

        public IPriceListItemRepo PriceListItems { get; private set; }

        public IRenterRepo Renters { get; private set; }

        public IRenterPassportRepo RenterPassports { get; private set; }

        public IVehicleTypeRepo VehicleTypes { get; private set; }

        public int Complete()
        {
            return _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
