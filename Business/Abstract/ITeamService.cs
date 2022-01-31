using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeamService
    {
        IDataResult<List<Team>> GetAll();
        IResult Add(Team team);
        IResult Delete(Team team);
        IResult Update(Team team);
        Team GetById(int TeamId);



    }
}
