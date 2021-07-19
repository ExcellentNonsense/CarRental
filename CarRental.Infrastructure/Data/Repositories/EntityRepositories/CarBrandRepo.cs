using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;

namespace CarRental.Infrastructure.Data.Repositories
{
    class CarBrandRepo : EfRepository<CarBrand>, ICarBrandRepo
    {
        public CarBrandRepo(AppDbContext context) : base(context) { }
    }
}
