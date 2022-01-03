
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryUserDal //:IUserDal 
    {
        List<User> _users;
        public InMemoryUserDal()
        {
            _users = new List<User>
            {
                new User{UserId=1,FullName="Taha Toy",Job="Developer",Adress="Manisa",Email="t@t.com",NickName="test1",StarPoint=10,TeamId=1},
                 new User{UserId=2,FullName="Sena Toy",Job="Student",Adress="Manisa",Email="s@s.com",NickName="test2",StarPoint=20,TeamId=3},
                  new User{UserId=3,FullName="Hüseyin Toy",Job="Nurse",Adress="Manisa",Email="hu@hu.com",NickName="test3",StarPoint=30,TeamId=2},
                   new User{UserId=4,FullName="Hatice Toy",Job="Ceo",Adress="Manisa",Email="ha@ha.com",NickName="test4",StarPoint=40,TeamId=4}
            };
        }
                    
        public void Add(User user)
        {
            _users.Add(user);
        }

        public void Delete(User user)
        {
            User userToDelete = _users.SingleOrDefault(u=>u.UserId==user.UserId);

            _users.Remove(userToDelete);
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public List<User> GetAllByUserId(int userId)
        {
            return _users.Where(u=>u.UserId==userId).ToList();
        }

        public void Update(User user)
        {
            User userToUpdate = _users.SingleOrDefault(u => u.UserId == user.UserId);
            userToUpdate.UserId = user.UserId;
            userToUpdate.FullName = user.FullName;
            userToUpdate.Adress = user.Adress;
            userToUpdate.Email = user.Email;
            userToUpdate.Job = user.Job;
            userToUpdate.NickName = user.NickName;
            userToUpdate.TeamId = user.TeamId;
            userToUpdate.StarPoint = user.StarPoint;
        }
    }
}
