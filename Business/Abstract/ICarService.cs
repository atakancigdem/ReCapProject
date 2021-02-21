using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetCarsByBrandId(int brand);
        IDataResult<Car> GetCarsByColorId(int color);
        IDataResult<List<Car>> GetByld(int carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
