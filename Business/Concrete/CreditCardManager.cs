using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CreditCardManager:ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public IResult Add(CreditCard creditCard)
        {
           _creditCardDal.Add(creditCard);
            return new Result(true, "başarıyla eklendi");
        }
        public List<CreditCard> GetAll()
        {
            return _creditCardDal.GetAll();
        }


        public IResult Payment()
        {
            return new Result(true, " başarıyla ödendi");
        }

        public CreditCard GetById(int creditCardId)
        {
            return _creditCardDal.Get(x => x.CreditCardId == creditCardId);

        }
    }
}
