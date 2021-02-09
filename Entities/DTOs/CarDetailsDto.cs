﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailsDto : IDto
    {
        public int CarID { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
