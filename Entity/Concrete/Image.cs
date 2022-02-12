using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Image:IEntity
    {
        public int ImageId { get; set; }
        
        public string ImagePath { get; set; }
    }
}
