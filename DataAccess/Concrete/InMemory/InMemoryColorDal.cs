using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryColorDal : IColorDal
    {
        List<Color> _color;

        public InMemoryColorDal()
        {
            _color = new List<Color>
            {
                new Color{ColorId = 1, ColorName = "Red"},
                new Color{ColorId = 2, ColorName = "Blue"},
                new Color{ColorId = 3, ColorName = "Black"},
                new Color{ColorId = 4, ColorName = "Yellow"},
                new Color{ColorId = 5, ColorName = "Grey"}
            };
        }

        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
