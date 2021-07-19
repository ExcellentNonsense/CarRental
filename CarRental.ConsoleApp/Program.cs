using CarRental.Application.Services;
using CarRental.Application.ViewModels;
using CarRental.Infrastructure.Data;
using CarRental.Infrastructure.Data.Repositories;
using System;
using System.Data.Entity;
using System.Linq;

namespace CarRental.ConsoleApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Database.SetInitializer(new CarRentalDbInitializer());

            RunCommand();
        }

        private static void RunCommand()
        {
            Console.WriteLine("Select a command:\r\n" +
                            "1 - Get all cars;\r\n" +
                            "2 - Get all locations;\r\n" +
                            "3 - Get all renters with passport data;\r\n" +
                            "4 - Get the most popular car;\r\n" +
                            "5 - Add the car brand;\r\n" +
                            "6 - Get all car brands;\r\n" +
                            "7 - Edit the car brand;\r\n" +
                            "8 - Remove the car brand.\r\n");

            int cmdKey = Convert.ToInt32(Console.ReadLine());

            Console.Write("\r\n");

            switch (cmdKey)
            {
                case 1:
                    GetAllCars();
                    break;
                case 2:
                    GetAllLocations();
                    break;
                case 3:
                    GetAllRentersWithPassportData();
                    break;
                case 4:
                    GetMostPopularCar();
                    break;
                case 5:
                    AddCarBrand();
                    break;
                case 6:
                    GetAllCarBrands();
                    break;
                case 7:
                    EditCarBrand();
                    break;
                case 8:
                    RemoveCarBrand();
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }

            Console.ReadKey();

            RunCommand();
        }

        private static void GetAllCars()
        {
            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var carService = new CarService(repos);
                var cars = carService.GetAllCars();

                Console.WriteLine("Cars in total: " + cars.Count() + "\r\n");

                foreach (var car in cars)
                {
                    Console.WriteLine(
                        "Registration number: " + car.RegistrationNumber + "\r\n" +
                        "Model: " + car.Model + "\r\n" +
                        "Brand: " + car.Brand + "\r\n" +
                        "Type: " + car.Type + "\r\n" +
                        "Automatic transmission: " + BoolToString(car.HasAutomaticTransmission) + "\r\n" +
                        "Air conditioner: " + BoolToString(car.HasAirConditioner) + "\r\n" +
                        "Gps: " + BoolToString(car.HasGps) + "\r\n" +
                        "Sits number: " + car.SitsNumber + "\r\n" +
                        "Doors number: " + car.DoorsNumber + "\r\n" +
                        "Suitcases number: " + car.SuitcasesNumber + "\r\n" +
                        "Premium: " + BoolToString(car.IsPremium) + "\r\n" +
                        "Location: " + car.Location + "\r\n" +
                        "City: " + car.City + "\r\n"
                    );
                }
            }
        }

        private static void GetAllLocations()
        {
            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var locationService = new LocationService(repos);
                var locations = locationService.GetAllLocations();

                Console.WriteLine("Locations in total: " + locations.Count() + "\r\n");

                foreach (var location in locations)
                {
                    Console.WriteLine(
                        "Name: " + location.Name + "\r\n" +
                        "City: " + location.City + "\r\n"
                    );
                }
            }
        }
        
        private static void GetAllRentersWithPassportData()
        {
            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var renterService = new RenterService(repos);
                var renters = renterService.GetAllRentersWithPassportData();

                Console.WriteLine("Renters in total: " + renters.Count() + "\r\n");

                foreach (var renter in renters)
                {
                    Console.WriteLine(
                        "First name: " + renter.FirstName + "\r\n" +
                        "Last name: " + renter.LastName + "\r\n" +
                        "Full name: " + renter.FullName + "\r\n" +
                        "Birth date: " + renter.BirthDate + "\r\n" +
                        "Email: " + renter.Email + "\r\n" +
                        "Phone number: " + renter.PhoneNumber + "\r\n" +
                        "Passport number: " + renter.PassportNumber + "\r\n"
                    );
                }
            }
        }
        
        private static void GetMostPopularCar()
        {
            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var orderService = new OrderService(repos);
                var mostPopularCar = orderService.GetMostPopularCar();

                if (mostPopularCar.Count() != 0)
                {
                    if (mostPopularCar.Count() == 1)
                    {
                        Console.WriteLine($"The most popular car: {mostPopularCar.First()}.\r\n");
                    }
                    else
                    {
                        Console.WriteLine($"There are several most popular cars: {string.Join(", ", mostPopularCar)}.\r\n");
                    }
                }
                else
                {
                    Console.WriteLine("Unable to determine the most popular car.\r\n");
                }
            }
        }

        private static void AddCarBrand()
        {
            Console.WriteLine("Enter the brand name.");

            string name = Console.ReadLine();
            Console.Write("\r\n");

            var brand = new CarBrandViewModel
            {
                Name = name
            };

            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var carService = new CarService(repos);

                bool success = carService.AddCarBrand(brand);

                if (!success)
                {
                    Console.WriteLine("Invalid brand name.\r\n");
                    return;
                }
            }

            Console.WriteLine("Brand added successfully.\r\n");
        }

        private static void GetAllCarBrands()
        {
            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var carService = new CarService(repos);
                var brands = carService.GetAllCarBrands();

                Console.WriteLine("Car brands in total: " + brands.Count() + "\r\n");

                foreach (var brand in brands)
                {
                    Console.WriteLine(brand.Name);
                }
            }

            Console.Write("\r\n");
        }

        private static void EditCarBrand()
        {
            Console.WriteLine("Enter the car brand to edit.");

            string brandName = Console.ReadLine();
            Console.Write("\r\n");

            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var carService = new CarService(repos);
                var brand = carService.GetCarBrandByName(brandName);

                if (brand == null)
                {
                    Console.WriteLine("Car brand not found.");
                    return;
                }

                Console.WriteLine("Current data.");
                Console.WriteLine("Name: " + brand.Name);
                Console.Write("\r\n");
                Console.WriteLine("Enter new data.");
                Console.WriteLine("Enter the brand name.");

                string newBrandName = Console.ReadLine();
                Console.Write("\r\n");

                var editedBrand = new CarBrandViewModel
                {
                    Name = newBrandName
                };

                bool success = carService.UpdateCarBrand(editedBrand, brand.Name);

                if (!success)
                {
                    Console.WriteLine("Failed to update brand data.");
                    return;
                }

                Console.WriteLine("Data of the car brand updated successfully.");
            }

            Console.Write("\r\n");
        }

        private static void RemoveCarBrand()
        {
            Console.WriteLine("Enter the car brand to remove.");

            string brandName = Console.ReadLine();
            Console.Write("\r\n");

            using (var repos = new RepoUnitOfWork(new AppDbContext()))
            {
                var carService = new CarService(repos);
                var brand = carService.GetCarBrandByName(brandName);

                if (brand == null)
                {
                    Console.WriteLine("Car brand not found.");
                    return;
                }

                Console.WriteLine("Car brand data.");
                Console.WriteLine("Name: " + brand.Name);
                Console.Write("\r\n");

                Console.WriteLine("Remove? (Y/N).\r\n");
                
                if (!Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                Console.Write("\r\n");

                bool success = carService.RemoveCarBrand(brand.Name);

                if (!success)
                {
                    Console.WriteLine("Failed to remove car brand.");
                    return;
                }

                Console.WriteLine("Car brand removed successfully.");
            }

            Console.Write("\r\n");
        }

        private static string BoolToString(bool value)
        {
            return value ? "+" : "-";
        }
    }
}
