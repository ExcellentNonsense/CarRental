using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;

namespace CarRental.Infrastructure.Data.Repositories
{
    class RenterPassportRepo : EfRepository<RenterPassport>, IRenterPassportRepo
    {
        public RenterPassportRepo(AppDbContext context) : base(context) { }
    }
}
