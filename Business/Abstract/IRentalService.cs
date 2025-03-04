﻿using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IResult Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<decimal> TotalEarnings();
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<RentalDetailDto>> GetRentalUserDetails(int userId);
        IDataResult<bool> GetCheckRentDate(int carId, DateTime rentDate, DateTime? returnDate);

    }
}
