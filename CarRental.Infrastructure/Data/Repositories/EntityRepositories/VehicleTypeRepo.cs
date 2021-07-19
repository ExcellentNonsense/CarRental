using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;

namespace CarRental.Infrastructure.Data.Repositories
{
    class VehicleTypeRepo : EfRepository<VehicleType>, IVehicleTypeRepo
    {
        public VehicleTypeRepo(AppDbContext context) : base(context) { }
    }
}
