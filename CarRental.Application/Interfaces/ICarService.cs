using CarRental.Application.ViewModels;
using System.Collections.Generic;

namespace CarRental.Application.Interfaces
{
    interface ICarService
    {
        IEnumerable<CarViewModel> GetAllCars();

        bool AddCarBrand(CarBrandViewModel carBrandViewModel);
        IEnumerable<CarBrandViewModel> GetAllCarBrands();
        CarBrandViewModel GetCarBrandByName(string brandName);
        /// <param name="carBrandViewModel">New car brand data.</param>
        /// <param name="initialBrandName">Brand name before editing.</param>
        bool UpdateCarBrand(CarBrandViewModel carBrandViewModel, string initialBrandName);
        bool RemoveCarBrand(string brandName);
    }
}
