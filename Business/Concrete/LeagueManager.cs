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
    public class LeagueManager : ILeagueService
    {
        ILeagueDal _leagueDal;

        public LeagueManager(ILeagueDal leagueDal)
        {
            _leagueDal = leagueDal;
        }
        
        public IResult Add(League league)
        {
            _leagueDal.Add(league);
            return new Result(true,"Lig başarıyla eklendi");
        }

        public IResult Delete(League league)
        {
            _leagueDal.Delete(league);
            return new Result(true,"Lig başarıyla silindi");
        }

        public List<League> GetAll()
        {
            return _leagueDal.GetAll();
        }

        public League GetById(int leagueId)
        {
            return _leagueDal.Get(x=>x.LeagueId==leagueId);
        }

        public IResult Update(League league)
        {
            _leagueDal.Update(league);
            return new Result(true,"Lig başarıyla güncellendi");
        }
    }
}
