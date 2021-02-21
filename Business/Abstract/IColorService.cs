using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetColorId(int colorId);
        IDataResult<Color> GetColorName(string colorName);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
