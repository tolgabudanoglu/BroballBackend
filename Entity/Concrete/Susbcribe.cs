using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Susbcribe:IEntity
    {

        [Key] public int SubscribeId { get; set; }
        public string SubscribePrice { get; set; }
        public string SubscribeType { get; set; } 
        public string SubscribeAdvantages { get; set; }
        public string SubscribeAdvantages2 { get; set; }

    }
}
