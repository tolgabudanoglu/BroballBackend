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
                             join t in context.Teams on u.TeamId equals t.TeamId
                             join c in context.Cities on u.CitiesId equals c.CitiesId
                             join l in context.Leagues on u.LeagueId equals l.LeagueId
                             select new UserDetailDto
                             {
                                 UserId = u.UserId,
                                 Name = u.Name,
                                 LastName = u.LastName,
                                 Team = t.TeamName,
                                 TeamId = t.TeamId,
                                 StarPoint = u.StarPoint,
                                 CitiesId = c.CitiesId,
                                 CityName = c.CityName
                             };
                return result.ToList();
                           
            }
        }
    }
}
