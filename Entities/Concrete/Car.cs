﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car
    {
        public int CarId { get; set; } // Kimlik
        public int BrandId { get; set; } // Marka
        public int ColorId { get; set; } // Renk
        public int ModelYear { get; set; } // Model Yılı
        public int DailyPrice { get; set; } // Günlük Fiyat
        public string Description { get; set; } // Açıklama
    }
}
