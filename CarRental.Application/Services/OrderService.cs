using CarRental.Application.Interfaces;
using CarRental.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepoUnitOfWork _repos;

        public OrderService(IRepoUnitOfWork repoUnitOfWork)
        {
            _repos = repoUnitOfWork;
        }

        public IEnumerable<string> GetMostPopularCar()
        {
            var carOrdersNumber = _repos.Orders.GetAllWithCarData()
                .GroupBy(x => new { CarName = x.Item.Car.Model.Brand.Name + " " + x.Item.Car.Model.Name })
                .Select(x => new { x.Key.CarName, OrdersNumber = x.Count() })
                .OrderByDescending(x => x.OrdersNumber)
                .ToArray();

            var mostPopularCars = new List<string>();

            if (carOrdersNumber.Length == 0)
            {
                return mostPopularCars;
            }

            for (int i = 0, maxOrdersNumber = carOrdersNumber[0].OrdersNumber; i < carOrdersNumber.Length; i++)
            {
                var item = carOrdersNumber[i];

                if (item.OrdersNumber == maxOrdersNumber)
                {
                    mostPopularCars.Add(item.CarName);
                }
                else
                {
                    break;
                }
            }

            return mostPopularCars;
        }
    }
}
