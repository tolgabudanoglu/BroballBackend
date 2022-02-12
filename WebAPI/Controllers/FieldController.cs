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
    public class FieldController : Controller
    {
        IFieldService _fieldService;

        public FieldController(IFieldService fieldService)
        {
            _fieldService = fieldService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
           // IFieldService fieldService = new FieldManager(new EfFieldDal());
            var result = _fieldService.GetAll();
            return Ok(result);
        }
        [HttpPost("add")]
        public IActionResult Post(Field field)
        {
            var result = _fieldService.Add(field);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(Field field)
        {
            var result = _fieldService.Delete(field);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getfieldsbycitiesid")]
        public IActionResult GetFieldsByCities(int citiesId)
        {
            var result = _fieldService.GetFieldsByCityId(citiesId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }








       
    }
}
