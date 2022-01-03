using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            foreach (var user in userManager.GetAll())
            {
                Console.WriteLine(user.UserId);
                Console.WriteLine(user.FullName);
                Console.WriteLine(user.Job);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.Adress);
                Console.WriteLine(user.TeamId);
                Console.WriteLine(user.StarPoint);
                Console.WriteLine(user.NickName);
            }
          
            Console.WriteLine("---------------------------------------------------");
            //foreach (var user in userManager.GetAllByUserId(2))
            //{
            //    Console.WriteLine(user.FullName);
            //}
            //Console.WriteLine("---------------------------------------------------");
            //foreach (var user in userManager.GetByStarPoint(3,500000))
            //{
            //    Console.WriteLine(user.FullName);
            //}

         


        }
    }
}
