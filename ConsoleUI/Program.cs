using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CarManager carManager = new CarManager(new InMemoryCarDal());
            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }

            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();

            //inMemoryCarDal.Add( new Car { CarId = 3, BrandId = 3, ColorId = 5, DailyPrice = 450, ModelYear = 2017, Description = "Modern Araba"});
            Car car1 = new Car { CarId = 3, BrandId = 3, ColorId = 5, DailyPrice = 450, ModelYear = 2017, Description = "Modern Araba" };
            inMemoryCarDal.GetAll();
            inMemoryCarDal.GetByld(1);
            inMemoryCarDal.Update(car1);
            inMemoryCarDal.Delete(car1);

            
        }
    }
}
