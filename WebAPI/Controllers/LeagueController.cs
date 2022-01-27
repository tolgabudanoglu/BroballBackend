using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeagueController : Controller
    {

        ILeagueService _leagueService;

        public LeagueController(ILeagueService leagueService)
        {
            _leagueService = leagueService;
        }
        [HttpGet("getall")]
        public List<League> Get()
        {
            ILeagueService leagueService = new LeagueManager(new EfLeagueDal());
            var result = leagueService.GetAll();
            return result;
        }

        [HttpPost("add")]
        public  IActionResult Post(League league)
        {
            var result = _leagueService.Add(league);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(League league)
        {
            var result = _leagueService.Delete(league);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(League league)
        {
            var result = _leagueService.Update(league);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
