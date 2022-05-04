using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DataAccess.Concrete.EntityFramework
{
    public class BroballContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=borball.mssql.somee.com;packet size=4096;user id=cartcix_SQLLogin_1;pwd=lczsck2n6m;data source=borball.mssql.somee.com;persist security info=False;initial catalog=borball");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Inquery> Inqueries { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<Susbcribe> Susbcribes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<About> Abouts { get; set; }
    }
}
