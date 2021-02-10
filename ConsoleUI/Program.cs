using Business.Concrete;
using DataAccess.Concrete.EntityFramwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            CarsList();
            CarManager carManager = new CarManager(new EfCarDal());          
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Car car1 = new Car() { Id = 9, CarName = "Creta", BrandId = 22, ColorId = 3, ModelYear = 2019, DailyPrice = 600, Description = "Otomatik"};
            carManager.Update(car1);

        }

        private static void CarsList()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Name : " + car.CarName + "|" +  "Brand : " + car.BrandName + "|" + "Color : " +car.ColorName + "|" + "Price : " + car.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarName, car.DailyPrice);
            }
        }
    }
}
