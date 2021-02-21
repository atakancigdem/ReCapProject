using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramwork
{
    public class EfUserDal : IUserDal
    {
        public void Add(User entity)
        {
            using(CarDatabaseContext context = new CarDatabaseContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                return filter == null
                    ? context.Set<User>().ToList()
                    : context.Set<User>().Where(filter).ToList();
            }
        }

        public void Update(User entity)
        {
            using (CarDatabaseContext context = new CarDatabaseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
