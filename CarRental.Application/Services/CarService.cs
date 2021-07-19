using CarRental.Application.Interfaces;
using CarRental.Application.ViewModels;
using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Application.Services
{
    public class CarService : ICarService
    {
        private readonly IRepoUnitOfWork _repos;

        public CarService(IRepoUnitOfWork repoUnitOfWork)
        {
            _repos = repoUnitOfWork;
        }

        public IEnumerable<CarViewModel> GetAllCars()
        {
            return _repos.Cars.GetAllWithFullData()
                .Select(x => CarViewModel.CreateFromCar(x))
                .ToList();
        }

        public bool AddCarBrand(CarBrandViewModel carBrandViewModel)
        {
            if (!carBrandViewModel.Validate())
            {
                return false;
            }

            _repos.CarBrands.Add(new CarBrand
            {
                Name = carBrandViewModel.Name
            });

            _repos.Complete();

            return true;
        }

        public IEnumerable<CarBrandViewModel> GetAllCarBrands()
        {
            return _repos.CarBrands.GetAll()
                .Select(x => CarBrandViewModel.CreateFromCarBrand(x))
                .ToList();
        }

        public CarBrandViewModel GetCarBrandByName(string brandName)
        {
            if (string.IsNullOrWhiteSpace(brandName))
            {
                throw new ArgumentException();
            }

            return _repos.CarBrands.Find(x => x.Name.Equals(brandName, StringComparison.OrdinalIgnoreCase))
                .Select(x => CarBrandViewModel.CreateFromCarBrand(x))
                .SingleOrDefault();
        }

        public bool UpdateCarBrand(CarBrandViewModel carBrandViewModel, string initialBrandName)
        {
            if (!carBrandViewModel.Validate())
            {
                return false;
            }

            var brand = _repos.CarBrands.Find(x => x.Name.Equals(initialBrandName, StringComparison.OrdinalIgnoreCase))
                .SingleOrDefault();

            if (brand == null)
            {
                return false;
            }

            brand.Name = carBrandViewModel.Name;

            _repos.Complete();

            return true;
        }

        public bool RemoveCarBrand(string brandName)
        {
            var brand = _repos.CarBrands.Find(x => x.Name.Equals(brandName, StringComparison.OrdinalIgnoreCase))
                .SingleOrDefault();

            if (brand == null)
            {
                return false;
            }

            _repos.CarBrands.Remove(brand);

            _repos.Complete();

            return true;
        }
    }
}
