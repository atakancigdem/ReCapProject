using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; } // Kimlik
        public string CarName { get; set; }
        public int BrandId { get; set; } // Marka
        public int ColorId { get; set; } // Renk
        public int ModelYear { get; set; } // Model Yılı
        public int DailyPrice { get; set; } // Günlük Fiyat
        public string Description { get; set; } // Açıklama
    }
}
