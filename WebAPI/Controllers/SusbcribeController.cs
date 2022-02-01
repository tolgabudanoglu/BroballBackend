using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SusbcribeController : Controller
    {

        ISusbcribeService _susbcribeService;

        public SusbcribeController(ISusbcribeService susbcribeService)
        {
            _susbcribeService = susbcribeService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            ISusbcribeService SusbcribeService = new SusbcribeManager(new EfSusbcribeDal());
            var result = _susbcribeService.GetAll();
            return Ok(result);
        }
    }
}
