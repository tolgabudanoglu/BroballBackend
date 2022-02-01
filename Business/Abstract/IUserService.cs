using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
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

        IDataResult<List<User>> GetUsersByCityId(int id);
        IDataResult<List<User>> GetUsersByLeagueId(int id);

        IDataResult<List<UserDetailDto>> GetUserDetailsByCityId(int id);

        //List<User> GetAllByUserId(int userId);
        //List<User> GetAllByUserId(int userId);
        //List<User> GetByStarPoint(int min,int max);
    }
}
