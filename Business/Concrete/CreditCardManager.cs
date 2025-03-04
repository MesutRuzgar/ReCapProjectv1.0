﻿using Business.Abstract;
using Business.Constants;
using Core.Entites.Concrete;
using Core.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {
            _creditCardDal.Add(creditCard);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CreditCard creditCard)
        {
            _creditCardDal.Delete(creditCard);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(),Messages.Listed);
        }

        public IDataResult<List<CreditCardDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CreditCardDetailDto>>(_creditCardDal.GetCreditCardDetails(), Messages.Listed);
        }

        public IDataResult<bool> GetCheckCreditCard(string cardHolder, string cardNumber, string cvv, string expirationMonth,string expirationYear)
        {
            Thread.Sleep(5000);
            string bigCardHolder = cardHolder.ToUpper();
            bool varMi = false;
            var result = _creditCardDal.GetCreditCardDetails().Any(c => c.CardHolder==bigCardHolder && c.CardNumber==cardNumber &&c.Cvv==cvv && c.ExpirationMonth == expirationMonth && c.ExpirationYear== expirationYear);
            if (result)
            {
                varMi = true;
                
            }            
                return new SuccessDataResult<bool>(varMi);            
        }

        public IDataResult<List<CreditCard>> GetCreditCardByUserId(int userId)
        {
            return new SuccessDataResult<List<CreditCard>>(_creditCardDal.GetAll(c=>c.UserId==userId), Messages.Listed);
        }

        public IDataResult<CreditCard> GetUserFindeksScore(int userId)
        {
            var result = _creditCardDal.GetUserFindeksScore(userId);
           
            return new SuccessDataResult<CreditCard>(result);
        }

        public IResult Update(CreditCard creditCard)
        {
            _creditCardDal.Update(creditCard);
            return new SuccessResult(Messages.Updated);
        }
       
    }
}
