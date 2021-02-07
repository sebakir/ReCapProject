using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarID = 1 , BrandID = 1 , ColorID = 1 , DailyPrice = 5 , ModelYear = "2020" ,Descriptions = "Audi 3" },
                new Car{CarID = 2 , BrandID = 2 , ColorID = 2 , DailyPrice = 4 , ModelYear = "2019" ,Descriptions= "Toyota" },
                new Car{CarID = 3 , BrandID = 3 , ColorID = 3 , DailyPrice = 3 , ModelYear = "2018" ,Descriptions = "Mercedes" },
                new Car{CarID = 4 , BrandID = 4 , ColorID = 4 , DailyPrice = 2 , ModelYear = "2017" ,Descriptions = "Porche" },
                new Car{CarID = 5 , BrandID = 5 , ColorID = 5 , DailyPrice = 1 , ModelYear = "2021" ,Descriptions = "BMW" }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _car.FirstOrDefault(c => c.CarID == car.CarID);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.CarID == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarID == car.CarID);
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Descriptions = car.Descriptions;
        }
    }
}
