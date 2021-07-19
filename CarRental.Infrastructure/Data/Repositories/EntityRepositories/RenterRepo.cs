using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.Infrastructure.Data.Repositories
{
    class RenterRepo : EfRepository<Renter>, IRenterRepo
    {
        public RenterRepo(AppDbContext context) : base(context) { }

        public IEnumerable<Renter> GetAllWithPassportData()
        {
            return ctx.Set<Renter>()
                .Include(x => x.Passport)
                .ToList();
        }
    }
}
