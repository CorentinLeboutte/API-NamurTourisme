using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repository.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeThemeController : ControllerBase
    {

        private TypeThemeRepository _typeRepo;
        public TypeThemeController(TypeThemeRepository typeRepo)
        {
            _typeRepo = typeRepo;
        }

        //CREATE

        [Route("Create")]
        public IActionResult Create([FromBody] TypeTheme typeTheme)
        {
            int success = _typeRepo.Create(typeTheme);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }


        //UPDATE

        [Route("Update")]
        public IActionResult Update([FromBody] TypeTheme typeTheme)
        {
            int success = _typeRepo.Update(typeTheme);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }

        //DELETE

        [Route("Delete/{Id}")]
        public IActionResult Delete(/*[FromRoute]*/ int Id)
        {
            _typeRepo.Delete(Id);
            return Ok();
        }

        //GET

        [Route("Get")]
        public IActionResult Get()
        {
            IEnumerable<TypeTheme> list = _typeRepo.Get();
            return Ok(list);
        }

        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            TypeTheme type = new TypeTheme();
            type = _typeRepo.GetById(Id);
            return Ok(type);

        }
    }
}
