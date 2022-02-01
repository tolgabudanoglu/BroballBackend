using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        User GetById(int userId);
        IResult Login(string email, string password);

        //List<User> GetAllByUserId(int userId);
        //List<User> GetAllByUserId(int userId);
        //List<User> GetByStarPoint(int min,int max);
    }
}
