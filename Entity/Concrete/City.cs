using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class City:IEntity
    {
        [Key]
        public int CitiesId { get; set; }
        public string CityName { get; set; }
    }
}
