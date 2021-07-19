using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.Infrastructure.Data.Repositories
{
    class CarRepo : EfRepository<Car>, ICarRepo
    {
        public CarRepo(AppDbContext context) : base(context) { }

        public IEnumerable<Car> GetAllWithFullData()
        {
            return ctx.Set<Car>()
                .Include(x => x.Model)
                .Include(x => x.Model.Brand)
                .Include(x => x.Model.Type)
                .Include(x => x.Location)
                .Include(x => x.Location.City)
                .ToList();
        }
    }
}
