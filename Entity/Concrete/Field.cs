using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Field:IEntity
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public int CitiesId { get; set; }
    }
}
