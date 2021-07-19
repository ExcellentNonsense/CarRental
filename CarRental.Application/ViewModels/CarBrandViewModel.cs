using CarRental.Domain.Entities;

namespace CarRental.Application.ViewModels
{
    public class CarBrandViewModel
    {
        public string Name { get; set; }

        public static CarBrandViewModel CreateFromCarBrand(CarBrand brand)
        {
            return new CarBrandViewModel
            {
                Name = brand.Name
            };
        }

        public bool Validate() =>
            !string.IsNullOrEmpty(Name) &&
            Name.Length <= 40;
    }
}
