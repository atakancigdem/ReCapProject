using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Message.CarNameInvalid);
            }
            _carDal.Add(car);
            return new SuccessResult(Message.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Message.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Car>>(Message.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>( _carDal.GetAll(), Message.CarsListed);
        }

        public IDataResult<List<Car>> GetByld(int carId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CarId == carId), Message.CarFound);
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CarId != carId), Message.NoCarFound);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brand)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brand));
        }
        public IDataResult<List<Car>> GetCarsByColorId(int color)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == color));
        }

        public IResult Update(Car car)
        {
            if (car.CarName.Length < 2)
            {
                return new ErrorResult(Message.CarNameInvalid);
            }
            _carDal.Update(car);
            return new SuccessResult(Message.CarUpdated);
        }
    }
}
