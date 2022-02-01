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
    public class SusbcribeManager : ISusbcribeService
    {
        ISusbcribeDal _susbcribeDal;
        public SusbcribeManager(ISusbcribeDal susbcribeDal)
        {
            _susbcribeDal = susbcribeDal;
        }

        public IDataResult<List<Susbcribe>> GetAll()
        {
            return new SuccessDataResult<List<Susbcribe>>(_susbcribeDal.GetAll());
        }
    }
}
