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
    public class ColorManager : IColorService
    {
        IColorDal _color;

        public ColorManager(IColorDal color)
        {
            _color = color;
        }

        public IResult Add(Color color)
        {
            _color.Add(color);
            return new Result(true);
        }

        public IResult Delete(Color color)
        {
           _color.Delete(color);
            return new Result(true);
            
        }

        public IDataResult <List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>> (_color.GetAll());
            
        }

        public IDataResult <List<Color>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Color>> (_color.GetAll(c=>c.ColorId == id));
        }

        public IDataResult <List<Color>> GetCarByBrandId(int id)
        {
           return new SuccessDataResult<List<Color>> (_color.GetAll(c=>c.ColorId== id));
        }

        public IResult Update(Color color)
        {
            _color.Update(color);
            return new Result(true,Messages.Updated);
        }
    }
}
