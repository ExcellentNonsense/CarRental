using System;

namespace CarRental.Domain.Interfaces.Repositories
{
    public interface IRepoUnitOfWork : IDisposable
    {
        ICarBrandRepo CarBrands { get; }
        ICarModelRepo CarModels { get; }
        ICarRepo Cars { get; }
        ICityRepo Cities { get; }
        ILocationRepo Locations { get; }
        IOrderRepo Orders { get; }
        IPriceListItemRepo PriceListItems { get; }
        IRenterRepo Renters { get; }
        IRenterPassportRepo RenterPassports { get; }
        IVehicleTypeRepo VehicleTypes { get; }

        int Complete();
    }
}
