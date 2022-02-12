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
    public class TeamsController: ControllerBase
    {
        ITeamService _teamService;
        public TeamsController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            ITeamService teamService = new TeamManager(new EfTeamDal());
            var result = teamService.GetAll();
            return Ok(result);
        }

        [HttpPost("post")]
        public IActionResult Post(Team team)
        {
            var result = _teamService.Add(team);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Team team)
        {
            var result = _teamService.Update(team);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getteamsbyleagueid")]
        public IActionResult GetFieldsByCities(int leagueId)
        {
            var result = _teamService.GetTeamsByLeagueId(leagueId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Team team)
        {
            var result = _teamService.Delete(team);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
