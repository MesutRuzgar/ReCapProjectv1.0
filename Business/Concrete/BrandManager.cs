﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager:IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            Console.WriteLine(brand.BrandName+ "------MARKA EKLENDI----");
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Console.WriteLine(brand.BrandName+ "------MARKA SILINDI----");
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return  _brandDal.GetAll();
        }
        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
            
        }

        public void Update(Brand brand)
        {
            Console.WriteLine(brand.BrandName+ "------MARKA GUNCELLENDI----");
            _brandDal.Update(brand);
        }
    }
}
