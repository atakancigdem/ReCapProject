using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService 
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserId(int userId);
        IDataResult<List<User>> GetUserName(string firstName, string lastName);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);

    }
}
