﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetById(int Id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
