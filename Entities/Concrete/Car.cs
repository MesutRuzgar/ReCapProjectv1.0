﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }       
        public int ColorId { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public decimal FindeksScore { get; set; }


    }
}
