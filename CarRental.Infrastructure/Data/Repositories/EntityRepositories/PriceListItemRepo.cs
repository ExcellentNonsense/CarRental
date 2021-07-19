using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;

namespace CarRental.Infrastructure.Data.Repositories
{
    class PriceListItemRepo : EfRepository<PriceListItem>, IPriceListItemRepo
    {
        public PriceListItemRepo(AppDbContext context) : base(context) { }
    }
}
