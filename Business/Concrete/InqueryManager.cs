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
    public class InqueryManager : IInqueryService
    {
        IInqueryDal _inqueryDal;
        public InqueryManager(IInqueryDal inqueryDal)
        {
            _inqueryDal = inqueryDal;
        }
        public IResult Add(Inquery inquery)
        {
            _inqueryDal.Add(inquery);
            return new Result(true, "Soru Başarıyla Gönderildi");
        }
        public IDataResult<List<Inquery>> GetAll()
        {
            return new SuccessDataResult<List<Inquery>>(_inqueryDal.GetAll());
        }


    }
}
