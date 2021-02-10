using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<CarDetailDto> GetCarDetails();
        List<Car> GetCarsByBrandId(int brand);
        List<Car> GetCarsByColorId(int color);
        List<Car> GetByld(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
