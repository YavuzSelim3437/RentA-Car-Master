using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentDal _rentdal;

        public RentalManager(IRentDal rentdal)
        {
            _rentdal = rentdal;
        }

        public IResult Add(Rental rental)
        {
           _rentdal.Add(rental);
            return new Result(true);

        }

        public IResult Delete(Rental rental)
        {
           _rentdal.Delete(rental);
            return new Result(true);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentdal.GetAll(), true, Messages.Listed);
        }

        public IResult Update(Rental rental)
        {
           _rentdal.Update(rental); 
           return new Result(true);
        }
    }
}
