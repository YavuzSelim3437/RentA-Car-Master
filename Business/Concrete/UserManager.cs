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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User users)
        {
            _userDal.Add(users);
            return new Result(true);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetbyId(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u=>u.UserId == id));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true);
        }
    }
}
