using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using(CarDatabaseContext context = new CarDatabaseContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers on r.CustomerId equals c.CustomerId
                             join u in context.Users on c.UserId equals u.UserId
                             join ca in context.Cars on r.CarId equals ca.CarId
                             select new RentalDetailDto
                             {
                                 Id = r.Id,
                                 CarId = ca.CarId,
                                 CarName = ca.CarName,
                                 CompanyName = c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                             };
                return result.ToList();
            }
        }
    }
}
