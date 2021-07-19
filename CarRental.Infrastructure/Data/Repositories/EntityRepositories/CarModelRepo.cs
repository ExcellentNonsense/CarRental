using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;

namespace CarRental.Infrastructure.Data.Repositories
{
    class CarModelRepo : EfRepository<CarModel>, ICarModelRepo
    {
        public CarModelRepo(AppDbContext context) : base(context) { }
    }
}
