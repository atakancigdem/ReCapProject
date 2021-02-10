using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetBrandId(int brand);
        Brand GetBrandName(string brandName);
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
    }
}
