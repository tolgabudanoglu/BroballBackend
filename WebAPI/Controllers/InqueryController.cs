using Business.Abstract;
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
    public class InqueryController: Controller
    {

        IInqueryService _inqueryService;

        public InqueryController(IInqueryService inqueryService)
        {
            _inqueryService = inqueryService;
        }

        [HttpPost("add")]
        public IActionResult Post(Inquery inquery)
        {
            var result = _inqueryService.Add(inquery);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }



    }
}
