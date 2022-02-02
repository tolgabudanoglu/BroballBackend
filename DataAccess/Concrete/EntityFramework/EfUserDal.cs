using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal :EfEntityRepositoryBase<User, BroballContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using(var context = new BroballContext())
            {
                var result = from u in context.Users
                             
                             
                             
                             select new UserDetailDto
                             {
                                 UserId = u.UserId,
                                 Name = u.Name,
                                 LastName = u.LastName,
                                 StarPoint = u.StarPoint,
                                 
                                
                             };
                return result.ToList();
                           
            }
        }
    }
}
