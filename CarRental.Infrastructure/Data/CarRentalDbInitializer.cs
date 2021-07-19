using CarRental.Domain.Entities;
using System;
using System.Data.Entity;

namespace CarRental.Infrastructure.Data
{
    public class CarRentalDbInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            #region CarBrand

            var carBrandToyota = new CarBrand { Name = "Toyota" };
            var carBrandJeep = new CarBrand { Name = "Jeep" };
            var carBrandBmw = new CarBrand { Name = "BMW" };
            var carBrandVolvo = new CarBrand { Name = "Volvo" };
            var carBrandMercedesBenz = new CarBrand { Name = "Mercedes-Benz" };
            var carBrandVolkswagen = new CarBrand { Name = "Volkswagen" };

            context.CarBrands.AddRange(new[]
            {
                carBrandToyota,
                carBrandJeep,
                carBrandBmw,
                carBrandVolvo,
                carBrandMercedesBenz,
                carBrandVolkswagen
            });

            #endregion

            #region VehicleType

            var vehicleTypeSuv = new VehicleType { Name = "SUV" };
            var vehicleTypeSedan = new VehicleType { Name = "Sedan" };

            context.VehicleTypes.AddRange(new[]
            {
                vehicleTypeSuv,
                vehicleTypeSedan
            });

            #endregion

            #region CarModel

            var carModelToyotaRav4 = new CarModel
            {
                Name = "RAV4",
                Brand = carBrandToyota,
                Type = vehicleTypeSuv,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = false,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = false
            };

            var carModelJeepGrandCherokee = new CarModel
            {
                Name = "Grand Cherokee",
                Brand = carBrandJeep,
                Type = vehicleTypeSuv,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = false,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 3,
                IsPremium = false
            };

            var carModelBmw3Series = new CarModel
            {
                Name = "3 Series",
                Brand = carBrandBmw,
                Type = vehicleTypeSedan,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = true,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = true
            };

            var carModelVolvoS90 = new CarModel
            {
                Name = "S90",
                Brand = carBrandVolvo,
                Type = vehicleTypeSedan,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = true,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = true
            };

            var carModelToyotaCamry = new CarModel
            {
                Name = "Camry",
                Brand = carBrandToyota,
                Type = vehicleTypeSedan,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = false,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = false
            };

            var carModelMercedesBenzAClass = new CarModel
            {
                Name = "A-Class",
                Brand = carBrandMercedesBenz,
                Type = vehicleTypeSedan,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = false,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = true
            };

            var carModelVolkswagenAtlas = new CarModel
            {
                Name = "Atlas",
                Brand = carBrandVolkswagen,
                Type = vehicleTypeSuv,
                HasAutomaticTransmission = true,
                HasAirConditioner =true ,
                HasGps = false,
                SitsNumber = 7,
                DoorsNumber = 4,
                SuitcasesNumber = 1,
                IsPremium = false
            };

            var carModelBmwX1 = new CarModel
            {
                Name = "X1",
                Brand = carBrandBmw,
                Type = vehicleTypeSuv,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = false,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = true
            };

            var carModelVolvoXC60 = new CarModel
            {
                Name = "XC60",
                Brand = carBrandVolvo,
                Type = vehicleTypeSuv,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = false,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = true
            };

            var carModelMercedesBenzGle = new CarModel
            {
                Name = "GLE",
                Brand = carBrandMercedesBenz,
                Type = vehicleTypeSuv,
                HasAutomaticTransmission = true,
                HasAirConditioner = true,
                HasGps = true,
                SitsNumber = 5,
                DoorsNumber = 4,
                SuitcasesNumber = 2,
                IsPremium = true
            };

            context.CarModels.AddRange(new[]
            {
                carModelToyotaRav4,
                carModelJeepGrandCherokee,
                carModelBmw3Series,
                carModelVolvoS90,
                carModelToyotaCamry,
                carModelMercedesBenzAClass,
                carModelVolkswagenAtlas,
                carModelBmwX1,
                carModelVolvoXC60,
                carModelMercedesBenzGle
            });

            #endregion

            #region City

            var cityLosAngeles = new City
            {
                Name = "Los Angeles"
            };

            var cityMiami = new City
            {
                Name = "Miami"
            };

            var cityFortLauderdale = new City
            {
                Name = "Fort Lauderdale"
            };

            var citySanFrancisco = new City
            {
                Name = "San Francisco"
            };

            var cityOrlando = new City
            {
                Name = "Orlando"
            };

            context.Cities.AddRange(new[]
            {
                cityLosAngeles,
                cityMiami,
                cityFortLauderdale,
                citySanFrancisco,
                cityOrlando
            });

            #endregion

            #region Location

            var locationLAMalibu = new Location
            {
                Name = "Malibu",
                City = cityLosAngeles
            };

            var locationLABrentwood = new Location
            {
                Name = "Brentwood",
                City = cityLosAngeles
            };

            var locationLASantaMonica = new Location
            {
                Name = "Santa Monica",
                City = cityLosAngeles
            };

            var locationLAVenice = new Location
            {
                Name = "Venice",
                City = cityLosAngeles
            };

            var locationMIAIntAirport = new Location
            {
                Name = "Int Airport",
                City = cityMiami
            };

            var locationMIADowntown = new Location
            {
                Name = "Downtown",
                City = cityMiami
            };

            var locationMIALincolnRoad = new Location
            {
                Name = "Lincoln Road",
                City = cityMiami
            };

            var locationFLPompanoBeach = new Location
            {
                Name = "Pompano Beach",
                City = cityFortLauderdale
            };

            var locationFLPortEverglades = new Location
            {
                Name = "Port Everglades",
                City = cityFortLauderdale
            };

            var locationFLIntAirport = new Location
            {
                Name = "Int Airport",
                City = cityFortLauderdale
            };

            var locationSFFishermansWharf = new Location
            {
                Name = "Fisherman's Wharf",
                City = citySanFrancisco
            };

            var locationSFUnionSquare = new Location
            {
                Name = "Union Square",
                City = citySanFrancisco
            };

            var locationSFMissionDistrict = new Location
            {
                Name = "Mission District",
                City = citySanFrancisco
            };

            var locationORLNearDisneyWorld = new Location
            {
                Name = "Near Disney World",
                City = cityOrlando
            };

            var locationORLLakeBuenaVista = new Location
            {
                Name = "Lake Buena Vista",
                City = cityOrlando
            };

            var locationORLInternationalDrive = new Location
            {
                Name = "International Drive",
                City = cityOrlando
            };

            var locationORLIntAirport = new Location
            {
                Name = "Int Airport",
                City = cityOrlando
            };

            context.Locations.AddRange(new[]
            {
                locationLAMalibu,
                locationLABrentwood,
                locationLASantaMonica,
                locationLAVenice,
                locationMIAIntAirport,
                locationMIADowntown,
                locationMIALincolnRoad,
                locationFLPompanoBeach,
                locationFLPortEverglades,
                locationFLIntAirport,
                locationSFFishermansWharf,
                locationSFUnionSquare,
                locationSFMissionDistrict,
                locationORLNearDisneyWorld,
                locationORLLakeBuenaVista,
                locationORLInternationalDrive,
                locationORLIntAirport
            });

            #endregion

            #region Car

            var carErs8579 = new Car
            {
                RegistrationNumber = "ERS-8579",
                Model = carModelBmw3Series,
                Location = locationFLIntAirport
            };

            var car5865GX = new Car
            {
                RegistrationNumber = "586 5GX",
                Model = carModelJeepGrandCherokee,
                Location = locationFLIntAirport
            };

            var car485JKM = new Car
            {
                RegistrationNumber = "485-JKM",
                Model = carModelMercedesBenzAClass,
                Location = locationLABrentwood
            };

            var car682GKS = new Car
            {
                RegistrationNumber = "682-GKS",
                Model = carModelToyotaCamry,
                Location = locationMIADowntown
            };

            var carDFLK7A = new Car
            {
                RegistrationNumber = "DF LK7A",
                Model = carModelVolkswagenAtlas,
                Location = locationORLIntAirport
            };

            var carJHS879 = new Car
            {
                RegistrationNumber = "JHS 879",
                Model = carModelVolvoS90,
                Location = locationSFFishermansWharf
            };

            var car4CF6879 = new Car
            {
                RegistrationNumber = "4C F6879",
                Model = carModelBmwX1,
                Location = locationSFFishermansWharf
            };

            var carFDS45C = new Car
            {
                RegistrationNumber = "FDS 45C",
                Model = carModelMercedesBenzAClass,
                Location = locationMIALincolnRoad
            };

            var carNSG586 = new Car
            {
                RegistrationNumber = "NSG 586",
                Model = carModelToyotaRav4,
                Location = locationLAVenice
            };

            var carUYR869 = new Car
            {
                RegistrationNumber = "UYR 869",
                Model = carModelVolvoXC60,
                Location = locationMIAIntAirport
            };

            context.Cars.AddRange(new[]
            {
                carErs8579,
                car5865GX,
                car485JKM,
                car682GKS,
                carDFLK7A,
                carJHS879,
                car4CF6879,
                carFDS45C,
                carNSG586,
                carUYR869
            });

            #endregion

            #region PriceListItem

            var priceListItem1 = new PriceListItem
            {
                Car = carErs8579,
                PricePerDay = 39.30M
            };

            var priceListItem2 = new PriceListItem
            {
                Car = car5865GX,
                PricePerDay = 33.96M
            };

            var priceListItem3 = new PriceListItem
            {
                Car = car485JKM,
                PricePerDay = 38.30M
            };

            var priceListItem4 = new PriceListItem
            {
                Car = car682GKS,
                PricePerDay = 30.30M
            };

            var priceListItem5 = new PriceListItem
            {
                Car = carDFLK7A,
                PricePerDay = 38.63M
            };

            var priceListItem6 = new PriceListItem
            {
                Car = carJHS879,
                PricePerDay = 44.96M
            };

            var priceListItem7 = new PriceListItem
            {
                Car = car4CF6879,
                PricePerDay = 39.96M
            };

            var priceListItem8 = new PriceListItem
            {
                Car = carFDS45C,
                PricePerDay = 38.30M
            };

            var priceListItem9 = new PriceListItem
            {
                Car = carNSG586,
                PricePerDay = 31.30M
            };

            var priceListItem10 = new PriceListItem
            {
                Car = carUYR869,
                PricePerDay = 41.43M
            };

            context.PriceListItems.AddRange(new[]
            {
                priceListItem1,
                priceListItem2,
                priceListItem3,
                priceListItem4,
                priceListItem5,
                priceListItem6,
                priceListItem7,
                priceListItem8,
                priceListItem9,
                priceListItem10
            });

            #endregion

            #region Renter

            var renter1 = new Renter
            {
                FirstName = "Merrile",
                LastName = "Gartan",
                Email = "mgartan1@ameblo.jp",
                PhoneNumber = "0123456789",
                Passport = new RenterPassport
                {
                    Number = "012345678",
                    BirthDate = new DateTime(1959, 2, 18)
                }
            };

            var renter2 = new Renter
            {
                FirstName = "Artur",
                LastName = "Seamer",
                Email = "aseamer2@jalbum.net",
                PhoneNumber = "1123456789",
                Passport = new RenterPassport
                {
                    Number = "112345678",
                    BirthDate = new DateTime(1973, 5, 1)
                }
            };

            var renter3 = new Renter
            {
                FirstName = "Mac",
                LastName = "Lukehurst",
                Email = "mlukehurst3@elpais.com",
                PhoneNumber = "2123456789",
                Passport = new RenterPassport
                {
                    Number = "212345678",
                    BirthDate = new DateTime(1962, 9, 29)
                }
            };

            var renter4 = new Renter
            {
                FirstName = "Chandler",
                LastName = "Northeast",
                Email = "cnortheast4@myspace.com",
                PhoneNumber = "3123456789",
                Passport = new RenterPassport
                {
                    Number = "312345678",
                    BirthDate = new DateTime(1992, 3, 7)
                }
            };

            var renter5 = new Renter
            {
                FirstName = "Chloe",
                LastName = "Paffley",
                Email = "cpaffley5@eepurl.com",
                PhoneNumber = "4123456789",
                Passport = new RenterPassport
                {
                    Number = "412345678",
                    BirthDate = new DateTime(1997, 12, 16)
                }
            };

            var renter6 = new Renter
            {
                FirstName = "Olympie",
                LastName = "Collumbell",
                Email = "ocollumbell6@geocities.jp",
                PhoneNumber = "5123456789",
                Passport = new RenterPassport
                {
                    Number = "512345678",
                    BirthDate = new DateTime(1986, 10, 2)
                }
            };

            var renter7 = new Renter
            {
                FirstName = "Frederigo",
                LastName = "Keuntje",
                Email = "fkeuntje7@flavors.me",
                PhoneNumber = "6123456789",
                Passport = new RenterPassport
                {
                    Number = "612345678",
                    BirthDate = new DateTime(1961, 9, 9)
                }
            };

            var renter8 = new Renter
            {
                FirstName = "Dyanne",
                LastName = "Bengal",
                Email = "dbengal8@uiuc.edu",
                PhoneNumber = "7123456789",
                Passport = new RenterPassport
                {
                    Number = "712345678",
                    BirthDate = new DateTime(1968, 4, 27)
                }
            };

            var renter9 = new Renter
            {
                FirstName = "Agneta",
                LastName = "Tidbold",
                Email = "atidbold9@hc360.com",
                PhoneNumber = "8123456789",
                Passport = new RenterPassport
                {
                    Number = "812345678",
                    BirthDate = new DateTime(1988, 11, 19)
                }
            };

            var renter10 = new Renter
            {
                FirstName = "Willis",
                LastName = "Puddicombe",
                Email = "wpuddicombea@foxnews.com",
                PhoneNumber = "9123456789",
                Passport = new RenterPassport
                {
                    Number = "912345678",
                    BirthDate = new DateTime(1994, 7, 1)
                }
            };

            var renter11 = new Renter
            {
                FirstName = "Reed",
                LastName = "Bryce",
                Email = "rbryceb@51.la",
                PhoneNumber = "0223456789",
                Passport = new RenterPassport
                {
                    Number = "022345678",
                    BirthDate = new DateTime(1994, 9, 26)
                }
            };

            var renter12 = new Renter
            {
                FirstName = "Patrice",
                LastName = "Bonome",
                Email = "pbonomec@senate.gov",
                PhoneNumber = "1223456789",
                Passport = new RenterPassport
                {
                    Number = "122345678",
                    BirthDate = new DateTime(1975, 8, 15)
                }
            };

            var renter13 = new Renter
            {
                FirstName = "Willie",
                LastName = "Seys",
                Email = "wseysd@t.co",
                PhoneNumber = "2223456789",
                Passport = new RenterPassport
                {
                    Number = "222345678",
                    BirthDate = new DateTime(1988, 10, 12)
                }
            };

            var renter14 = new Renter
            {
                FirstName = "Currey",
                LastName = "Lockart",
                Email = "clockarte@cpanel.net",
                PhoneNumber = "3223456789",
                Passport = new RenterPassport
                {
                    Number = "322345678",
                    BirthDate = new DateTime(1995, 1, 1)
                }
            };

            var renter15 = new Renter
            {
                FirstName = "Warden",
                LastName = "Banishevitz",
                Email = "wbanishevitzf@macromedia.com",
                PhoneNumber = "4223456789",
                Passport = new RenterPassport
                {
                    Number = "422345678",
                    BirthDate = new DateTime(1960, 11, 19)
                }
            };

            var renter16 = new Renter
            {
                FirstName = "Rustie",
                LastName = "MacCosty",
                Email = "rmaccostyg@booking.com",
                PhoneNumber = "5223456789",
                Passport = new RenterPassport
                {
                    Number = "522345678",
                    BirthDate = new DateTime(1981, 4, 8)
                }
            };

            var renter17 = new Renter
            {
                FirstName = "Shandie",
                LastName = "Whittock",
                Email = "swhittockh@bbb.org",
                PhoneNumber = "6223456789",
                Passport = new RenterPassport
                {
                    Number = "622345678",
                    BirthDate = new DateTime(1966, 6, 12)
                }
            };

            var renter18 = new Renter
            {
                FirstName = "Candra",
                LastName = "Cluckie",
                Email = "ccluckiei@seattletimes.com",
                PhoneNumber = "7223456789",
                Passport = new RenterPassport
                {
                    Number = "722345678",
                    BirthDate = new DateTime(1990, 6, 29)
                }
            };

            var renter19 = new Renter
            {
                FirstName = "Rockie",
                LastName = "Bantock",
                Email = "rbantockj@chicagotribune.com",
                PhoneNumber = "8223456789",
                Passport = new RenterPassport
                {
                    Number = "822345678",
                    BirthDate = new DateTime(1993, 9, 8)
                }
            };

            var renter20 = new Renter
            {
                FirstName = "Rochester",
                LastName = "Gabotti",
                Email = "rgabottik@typepad.com",
                PhoneNumber = "9223456789",
                Passport = new RenterPassport
                {
                    Number = "922345678",
                    BirthDate = new DateTime(1994, 1, 24)
                }
            };

            context.Renters.AddRange(new[]
            {
                renter1,
                renter2,
                renter3,
                renter4,
                renter5,
                renter6,
                renter7,
                renter8,
                renter9,
                renter10,
                renter11,
                renter12,
                renter13,
                renter14,
                renter15,
                renter16,
                renter17,
                renter18,
                renter19,
                renter20
            });

            #endregion

            #region Order

            var order1 = new Order
            {
                Renter = renter1,
                Item = priceListItem1,
                DaysQuantity = 1
            };

            var order2 = new Order
            {
                Renter = renter2,
                Item = priceListItem2,
                DaysQuantity = 2
            };

            var order3 = new Order
            {
                Renter = renter3,
                Item = priceListItem3,
                DaysQuantity = 3
            };

            var order4 = new Order
            {
                Renter = renter4,
                Item = priceListItem4,
                DaysQuantity = 4
            };

            var order5 = new Order
            {
                Renter = renter5,
                Item = priceListItem5,
                DaysQuantity = 5
            };

            var order6 = new Order
            {
                Renter = renter6,
                Item = priceListItem6,
                DaysQuantity = 6
            };

            var order7 = new Order
            {
                Renter = renter7,
                Item = priceListItem7,
                DaysQuantity = 7
            };

            var order8 = new Order
            {
                Renter = renter8,
                Item = priceListItem8,
                DaysQuantity = 8
            };

            var order9 = new Order
            {
                Renter = renter9,
                Item = priceListItem9,
                DaysQuantity = 9
            };

            var order10 = new Order
            {
                Renter = renter10,
                Item = priceListItem10,
                DaysQuantity = 10
            };

            var order11 = new Order
            {
                Renter = renter10,
                Item = priceListItem10,
                DaysQuantity = 8
            };

            context.Orders.AddRange(new[]
            {
                order1,
                order2,
                order3,
                order4,
                order5,
                order6,
                order7,
                order8,
                order9,
                order10,
                order11
            });

            #endregion

            base.Seed(context);
        }
    }
}
