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
<<<<<<< HEAD
            return _userService.GetAll();
=======
            // IUserService userService = new UserManager(new EfUserDal());
            var result = _userService.GetAll();
            return Ok(result);
>>>>>>> d84ba4c1128137e06c7f5521bde516193affa2e0
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
        [HttpGet("/Login")]
        public IResult Login(string mail, string password)
        {
            return _userService.Login(mail, password);
        }
        [HttpGet("/getUserByEmail")]
        public IResult GetUserByEmail(string email)
        {
            return _userService.GetUserByEmail(email);
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
=======

        [HttpGet("getusersbycitiesid")]
        public IActionResult GetUsersByCitiesId(int id)
        {
            var result = _userService.GetUsersByCityId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

>>>>>>> d84ba4c1128137e06c7f5521bde516193affa2e0
        }

            [HttpGet("/Login")]
            public IResult Login(string mail, string password)
            {
                return _userService.Login(mail, password);
            }
            [HttpGet("/getUserByEmail")]
            public IResult GetUserByEmail(string mail)
            {
                return _userService.GetUserByEmail(mail);

            }


        }
    }

