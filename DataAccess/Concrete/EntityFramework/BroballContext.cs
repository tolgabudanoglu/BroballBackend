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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=broball;Trusted_Connection=True ");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }

        public DbSet<Field> Fields { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Inquery> Inqueries { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
