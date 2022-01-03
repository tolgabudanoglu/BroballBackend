using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User:IEntity
    {
        public int UserId { get; set; }
        public string NickName { get; set; }
        public string FullName { get; set; }
        public string Job { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public int TeamId { get; set; }
        public int StarPoint { get; set; }
        public int CitiesId { get; set; }
    }
}