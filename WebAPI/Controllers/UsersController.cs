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
        public IActionResult Get()
        {
           // IUserService userService = new UserManager(new EfUserDal());
            var result = _userService.GetAll();
            return Ok(result);
        }

        [HttpPost("post")]
        public IActionResult Post(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(User user)
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

<<<<<<< HEAD
        [HttpGet("getusersbycitiesid")]
        public IActionResult GetUsersByCitiesId(int id)
        {
            var result = _userService.GetUsersByCityId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
=======
        [HttpGet("/Login")]
        public IResult Login(string mail, string password)
        {
            return _userService.Login(mail, password);
        }
        [HttpGet("/getUserByEmail")]
        public IResult GetUserByEmail(string mail)
        {
            return _userService.GetUserByEmail(mail);
>>>>>>> 0c6a465e12e65d76d26f141dfeb0a631b123f9f4
        }


    }
}
