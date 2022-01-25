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
        public List<Field> Get()
        {
            IFieldService fieldService = new FieldManager(new EfFieldDal());
            var result = fieldService.GetAll();
            return result;
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







       
    }
}
