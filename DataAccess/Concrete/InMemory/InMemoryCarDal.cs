using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 150, ModelYear = 2005, Description = "Geniş Araba"},
                new Car{CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 200, ModelYear = 2012, Description = "Bebek Koltuğu"},
                new Car{CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 300, ModelYear = 2015, Description = "Tek Kapı"},
                new Car{CarId = 4, BrandId = 4, ColorId = 5, DailyPrice = 350, ModelYear = 2019, Description = "Araba"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByld(int carId)
        {
            return _car.Where(c => c.CarId == carId).ToList();
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            Console.WriteLine("Güncellendi");
        }
    }
}
