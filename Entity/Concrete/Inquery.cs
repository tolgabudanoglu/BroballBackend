using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Inquery:IEntity
    {
        public int InqueryId { get; set; }
        public string Cevap { get; set; }
        public string Soru { get; set; }
    }
}
