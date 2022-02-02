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
<<<<<<< HEAD
        IResult GetUserById(int userId);
        IResult Login(string email, string password);
        IResult GetUserByEmail(string email);
        IResult SendMail(string email);
=======
     //   User GetById(int userId);
        IResult Login(string email, string password);
        IResult GetUserByEmail(string email);

        IDataResult<List<User>> GetUsersByCityId(int id);
        IDataResult<List<User>> GetUsersByLeagueId(int id);

        IDataResult<List<UserDetailDto>> GetUserDetailsByCityId(int id);

>>>>>>> d84ba4c1128137e06c7f5521bde516193affa2e0
        //List<User> GetAllByUserId(int userId);
        //List<User> GetAllByUserId(int userId);
        //List<User> GetByStarPoint(int min,int max);
    }
}
