using CarRental.Application.Services;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Data.Repositories;
using System.Data.Entity;
using System;

namespace CarRental.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new CarRentalDbInitializer());

            Console.

            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var carService = new CarService(repos);
                carService.GetAllCars();
            }
        }
    }
}
