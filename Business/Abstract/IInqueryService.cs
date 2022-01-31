using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInqueryService
    {
        
        IResult Add(Inquery inquery);
        public IDataResult<List<Inquery>> GetAll()
        {
            return new SuccessDataResult<List<Inquery>>(_inqueryDal.GetAll());
        }
    }
}
