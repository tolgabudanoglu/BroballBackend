using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
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
    public class UsersController : Controller
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IDataResult<List<User>> GetAll()
        {

            return _userService.GetAll();

        }

        [HttpPost("/post")]
        public IActionResult Post(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //[HttpPut("update")]
        //public IActionResult Update(User user)
        //{
        //    var result = _userService.Update(user);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpPut("/putUser")]
        public IActionResult Update([FromBody] User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }



        [HttpGet("getusersbycitiesid")]
        public IActionResult GetUsersByCities(int citiesId)
        {
            var result = _userService.GetUsersByCityId(citiesId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
       



        [HttpGet("/Login")]
            public IResult Login(string mail, string password)
            {
                return _userService.Login(mail, password);
            }

            //[HttpGet("/getUserByEmail")]
            //public IResult GetUserByEmail(string mail)
            //{
            //    return _userService.GetUserByEmail(mail);

            //}

        [HttpGet("getUserByEmail")]
        public IActionResult GetUserByEmail(string mail)
        {
            var result = _userService.GetUserByEmail(mail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("/getUserById")]
        public IResult GetUserById(int userId)
        {
            return _userService.GetUserById(userId);

        }

        [HttpGet("/sendMail")]
        public IResult SendMail(string email)
        {
            return _userService.SendMail(email);
        }
        [HttpGet("/sendMail2")]
        public IResult SendMail2(string email)
        {
            return _userService.SendMail2(email);
        }

        [HttpGet("/sendMail3")]
        public IResult SendMail3(string email)
        {
            return _userService.SendMail3(email);
        }


        //[HttpGet("getall")]
        //public IDataResult<List<User>> GetAll()
        //{

        //    return _userService.GetAll();

        //}

        
       
        

        [HttpGet("getusersbyuserid")]
        public IActionResult GetUsersByUser(int userId)
        {
            var result = _userService.GetUsersByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

       


        [HttpGet("getPasswordByUserId")]
        public IActionResult GetPasswordByUserId(int id)
        {
            var result = _userService.GetPasswordByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getStarPointByUserId")]
        public IActionResult GetStarPointByUserId(int id)
        {
            var result = _userService.GetStarPointByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getTeamIdByUserId")]
        public IActionResult GetTeamIdByUserId(int id)
        {
            var result = _userService.GetTeamIdByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getLeagueIdByUserId")]
        public IActionResult GetLeagueIdByUserId(int id)
        {
            var result = _userService.GetLeagueIdByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getSubscribeIdByUserId")]
        public IActionResult GetSubscribeIdByUserId(int id)
        {
            var result = _userService.GetSubscribeIdByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getAsistByUserId")]
        public IActionResult GetAsistByUserId(int id)
        {
            var result = _userService.GetAsistByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getCitiesIdByUserId")]
        public IActionResult GetCitiesIdByUserId(int id)
        {
            var result = _userService.GetCitiesIdByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getReasonForPenaltyByUserId")]
        public IActionResult GetReasonForPenaltyByUserId(int id)
        {
            var result = _userService.GetReasonForPenaltyByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getScoreByUserId")]
        public IActionResult GetScoreByUserId(int id)
        {
            var result = _userService.GetScoreByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getEmailByUserId")]
        public IActionResult GetEmailByUserId(int id)
        {
            var result = _userService.GetEmailByUserId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }







    } 

}
    

