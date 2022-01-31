using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICreditCardService
    {
        
        List<CreditCard> GetAll();
        CreditCard GetById(int CreditCardId);
        IResult Add(CreditCard creditCard);
        IResult Payment();
    }
}
