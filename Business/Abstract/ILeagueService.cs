using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILeagueService
    {

        IDataResult<List<League>> GetAll();
        IResult Add(League league);
        IResult Delete(League league);
        IResult Update(League league);
        League GetById(int leagueId);
    
    }
}
