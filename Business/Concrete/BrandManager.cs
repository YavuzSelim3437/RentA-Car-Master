using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brand;

        public BrandManager(IBrandDal brand)
        {
            _brand = brand;
        }

        public IResult Add(Brand brand)
        {
            _brand.Add(brand);
            return new Result(true,Messages.Added);
        }

        public IResult Delete(Brand brand)
        {
            _brand.Delete(brand);
            return new Result(true,Messages.Deleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brand.GetAll(), true, Messages.Listed);
        }

  

        public IDataResult<List<Brand>> GetCarByBrandId(int id)
        {
            return new SuccessDataResult<List<Brand>> (_brand.GetAll(p=>p.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            _brand.Update(brand);
            return new Result(true,Messages.Updated);
        }
    }
}
