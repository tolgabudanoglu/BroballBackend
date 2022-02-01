using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
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

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new Result(true,"Kullanıcı başarıyla eklendi");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true,"Kullanıcı başarıyla silindi");

        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public User GetById(int userId)
        {
            return _userDal.Get(x=>x.UserId==userId);

        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true,"Kullanıcı başarıyla güncellendi");
        }

        public IResult Login(string email, string password)
        {
            var result = _userDal.Get(user => user.Email == email);

            if (result == null)
                return new Result(false, "giriş başarısız");
            if (result.Password.Equals(password)) return new Result(true, "giriş başarılı");
            {
                return new Result(false, "giriş başarısız");
            }
        }
        public IResult GetUserByEmail(string email)

        {
            var result = _userDal.Get(user => email == user.Email);
            if (result == null)
            {
                return new ErrorResult("data yok");
            }

            return new SuccessDataResult<string>(result.UserId.ToString(), "data getirildi");

        }





        //public List<User> GetAllByUserId(int userId)
        //{
        //    return _userDal.GetAll(u=>u.UserId==userId);
        //}

        //public List<User> GetByStarPoint(int min, int max)
        //{
        //    return _userDal.GetAll(u=>u.StarPoint>=min && u.StarPoint<=max);
        //}
    }
}
