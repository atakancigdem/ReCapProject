using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            if(DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetail()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails());
        }

        public IDataResult<Customer> GetCustomerId(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.CustomerId == customerId), Messages.CustomerFound);
        }

        public IResult Update(Customer customer)
        {
            ValidationTool.Validate(new CustomerValidator(), customer);
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdate);
        }
    }
}
