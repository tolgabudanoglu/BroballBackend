using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICityService
    {
        List<City> GetAll();
        IResult Add(City city);
        IResult Delete(City city);
        City GetById(int citiesId);
    }
}
