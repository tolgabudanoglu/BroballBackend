using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CreditCard:IEntity
    {
        public int CreditCardId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string CardNumber { get; set; }
        public int ExpirationMounth { get; set; }
        public int ExpirationYear { get; set; }
        public int Cvv { get; set; }
    }
}
