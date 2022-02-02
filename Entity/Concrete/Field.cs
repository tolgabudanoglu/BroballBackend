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
        public string City { get; set; }
        public string FieldAdress { get; set; }
        public string PhoneNumber { get; set; }
        public int NumberOfPlayers { get; set; }
        public int OpenHour { get; set; }
        public int CloseHour { get; set; }

    }
}
