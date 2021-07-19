using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarRental.Infrastructure.Data.Repositories
{
    class OrderRepo : EfRepository<Order>, IOrderRepo
    {
        public OrderRepo(AppDbContext context) : base(context) { }

        public IEnumerable<Order> GetAllWithCarData()
        {
            return ctx.Set<Order>()
                .Include(x => x.Item.Car)
                .Include(x => x.Item.Car.Model)
                .Include(x => x.Item.Car.Model.Brand)
                .Include(x => x.Item.Car.Model.Type)
                .Include(x => x.Item.Car.Location)
                .Include(x => x.Item.Car.Location.City)
                .ToList();
        }
    }
}
