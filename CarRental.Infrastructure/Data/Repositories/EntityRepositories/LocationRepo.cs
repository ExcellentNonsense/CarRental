using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.Infrastructure.Data.Repositories
{
    class LocationRepo : EfRepository<Location>, ILocationRepo
    {
        public LocationRepo(AppDbContext context) : base(context) { }

        public IEnumerable<Location> GetAllWithFullData()
        {
            return ctx.Set<Location>()
                .Include(x => x.City)
                .ToList();
        }
    }
}
