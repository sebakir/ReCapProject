using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarID equals car.CarID
                             join customer in context.Customers
                             on rental.CustomerID equals customer.CustomerID
                             join brand in context.Brands
                             on car.BrandID equals brand.BrandID
                             join user in context.Users
                             on customer.UserID equals user.UserID
                             select new RentalDetailDto
                             {
                                 ID = rental.ID,
                                 CarID = car.CarID,
                                 FirstName = user.FirstName + " " + user.LastName,
                                 Descriptions = car.Descriptions,
                                 RentDate = rental.RentDate,
                                 ReturnDate = rental.ReturnDate
                             };
                return result.ToList();
            }


        }
    }
}
