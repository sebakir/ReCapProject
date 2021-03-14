using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentDal _rentDal;

        public RentalManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }

        public IResult Add(Rental rental)
        {
            var results = _rentDal.GetAll(r => r.CarID == rental.CarID); ;
            foreach (var result in results)
            {
                if (result.ReturnDate == null)
                {
                    return new ErrorResult(Messages.RentalNotAvailable);
                }
            }
            _rentDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            _rentDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentDal.GetAll());
        }

        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentDal.Get(r => r.ID == rentalId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailDtos()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentDal.GetRentalDetailDtos());

        }

        public IResult Update(Rental rental)
        {
            var updateRental = _rentDal.Get(r => r.CarID == rental.CarID);
            if (updateRental.RentDate != null)
            {
                return new ErrorResult(Messages.ReturnDateNotNull);
            }
            updateRental.RentDate = DateTime.Now;
            _rentDal.Update(updateRental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
