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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            _cityDal.Add(city);
            return new Result(true,"Şehir başarıyla eklendi");
        }

        public IResult Delete(City city)
        {
            _cityDal.Delete(city);
            return new Result(true,"Şehir başarıyla silindi");
        }

        public List<City> GetAll()
        {
            return _cityDal.GetAll();
        }

        public City GetById(int citiesId)
        {
            return _cityDal.Get(x=>x.CitiesId==citiesId);
        }
    }
}
