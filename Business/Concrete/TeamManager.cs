using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TeamManager : ITeamService
    {
        ITeamDal _teamDal;
        

        public TeamManager(ITeamDal teamDal)
        {
             _teamDal = teamDal;
        }
        public IResult Add(Team team)
        {
            _teamDal.Add(team);
            return new Result(true, "Takım Başarıyla Eklendi");
        }

        public IResult Delete(Team team)
        {
            _teamDal.Delete(team);
            return new Result(true, "Takım Başarıyla Silindi");
        }

        public IDataResult<List<Team>> GetAll()
        {
            return new SuccessDataResult<List<Team>>(_teamDal.GetAll());
        }

        public Team GetById(int teamId)
        {
            return _teamDal.Get(x => x.TeamId==teamId);
        }

        public IResult Update(Team team)
        {
            _teamDal.Update(team);
            return new Result(true, "Takım Başarıyla Eklendi");
        }
    }
}
