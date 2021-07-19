using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;

namespace CarRental.Infrastructure.Data.Repositories
{
    class CityRepo : EfRepository<City>, ICityRepo
    {
        public CityRepo(AppDbContext context) : base(context) { }
    }
}
