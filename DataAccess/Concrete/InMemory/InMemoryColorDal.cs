using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void Add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _color.SingleOrDefault(c => c.ColorId == color.ColorId);
            _color.Remove(colorToDelete);
        }

        public List<Color> GetAll()
        {
            return _color;
        }

        public List<Color> GetByld(int colorId)
        {
            return _color.Where(c => c.ColorId == colorId).ToList();
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _color.SingleOrDefault(c => c.ColorId == color.ColorId);
            colorToUpdate.ColorName = color.ColorName;
        }
    }
}
