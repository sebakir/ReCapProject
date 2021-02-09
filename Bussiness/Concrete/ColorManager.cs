using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal colorDal;

        public ColorManager(IColorDal colorDal)
        {
            this.colorDal = colorDal;
        }

        public void Add(Color color)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return colorDal.GetAll();
        }

        public List<Color> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
