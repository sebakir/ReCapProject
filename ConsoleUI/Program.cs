using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            // ColorTest();
            //BrandTest();

            // CarAddTest();
            //CarDetailTest();
            //UserAddTest();
            //CustomerAddTest();
            Rental rental = new Rental { CarID = 1, CustomerID = 1, RentDate = DateTime.Now };
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(rental);
        }

        private static void CustomerAddTest()
        {
            Customer customer = new Customer { CompanyName = "BMW", UserID = 1 };
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(customer);
        }

        private static void UserAddTest()
        {
            User user = new User { FirstName = "Seçkin", LastName = "Bakır", Email = "seckin.bakir@gmal.com" };
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(user);
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDtos();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "|" + car.ColorName + "|" + car.DailyPrice); ;
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAddTest()
        {
            Car car = new Car { BrandID = 1, ColorID = 2, DailyPrice = 700, Descriptions = "Yeni bmw", ModelYear = "2018" };
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDtos();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }


    }
}
