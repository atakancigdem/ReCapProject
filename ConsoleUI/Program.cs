using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());


            foreach (var brand in brandManager.GetBrandName("Ford"))
            {
                Console.WriteLine(brand.BrandId);
            }

            foreach (var car in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine(car.Description);
            }

            Car car1 = new Car();
            car1.BrandId = 4;
            car1.ColorId = 5;
            car1.DailyPrice = 700;
            car1.ModelYear = 2010;
            car1.Description = "Geniş Araba";

            Car car2 = new Car() {Id = 6, BrandId = 3, ColorId = 4, DailyPrice = 500, ModelYear = 2012, Description = "Çocuk Koltuğu" };
            

            EfCarDal efCarDal = new EfCarDal();

            efCarDal.Add(car2);
            efCarDal.Add(car1);
        }
    }
}
