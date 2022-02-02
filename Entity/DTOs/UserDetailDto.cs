using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTOs
{
    public class UserDetailDto:IEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Team { get; set; }
        public int TeamId { get; set; }
       
        public int StarPoint { get; set; }
        public int CitiesId { get; set; }
        public string CityName { get; set; }
    }
}
