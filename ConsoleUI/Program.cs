using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using Entities.Concrete;
using Core.Utilities;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdd();
            //CarUpdate();
            //CarDetailTest();            
            //UserAddTest();
            //CustomerAddTest();
            //RentalAddTest();
            //RentalsDetail();
            //CustomerDetailTest();
        }

        private static void CustomerDetailTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetCustomerDetail();

            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.FirstName + " " + customer.LastName + " / " + customer.Email + " / " + customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental
            {
                CarId = 11,
                CustomerId = 6,
                RentDate = DateTime.Today,
                ReturnDate = DateTime.Now,
            });
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                UserId = 6,
                CompanyName = "Yamanlar İnş."
            });
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Sabah",
                LastName = "Yamanlar",
                Email = "sabahyaman@gmail.com",
                Password = "655616"
            });
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Update(new Car
            {
                CarId = 11,
                CarName = "Süper Sports",
                BrandId = 27,
                ColorId = 1,
                DailyPrice = 700,
                ModelYear = 2010,
                Description = "Otomatik"
            });
        }

        private static void RentalsDetail()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();

            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.Id + " / " + rental.CarName + " / " + rental.CustomerId + " / " + rental.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                CarId = 10,
                CarName = "YENİ SUV",
                BrandId = 4,
                ColorId = 6,
                DailyPrice = 600,
                ModelYear = 2000,
                Description = "SUV"
            });
        }
    }
    
}
