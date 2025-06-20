﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                {
                    var result = from c in context.Cars
                                 join b in context.Brands
                              on c.BrandId equals b.BrandId
                                 join co in context.Colors
                              on c.ColorId equals co.ColorId
                                 select new CarDetailDto
                                 {
                                     CarId = c.CarId,
                                     Description = c.Description,
                                     BrandName = b.BrandName,
                                     ColorName = co.ColorName,
                                     DailyPrice = c.DailyPrice
                                 };

                    return result.ToList();


                    // ürünler ile kategorileri join et
                }
            }
        }
    }

}
