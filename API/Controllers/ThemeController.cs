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
    public class ThemeController : ControllerBase
    {
        private ThemeRepository _themeRepo;
        public ThemeController(ThemeRepository themeRepo)
        {
            _themeRepo = themeRepo;
        }

        //CREATE

        [Route("Create")]
        public IActionResult Create([FromBody] Theme theme)
        {
            int success = _themeRepo.Create(theme);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }


        //UPDATE

        [Route("Update")]
        public IActionResult Update([FromBody] Theme theme)
        {
            int success = _themeRepo.Update(theme);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }

        //DELETE

        [Route("Delete/{Id}")]
        public IActionResult Delete(/*[FromRoute]*/ int Id)
        {
            _themeRepo.Delete(Id);
            return Ok();
        }

        //GET

        [HttpGet]

        //[Route("Get")]
        public IActionResult Get()
        {
            IEnumerable<Theme> list = _themeRepo.Get();
            return Ok(list);
        }

        //[HttpGet]

        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Theme theme = new Theme();
            theme = _themeRepo.GetById(Id);
            return Ok(theme);
        }



    }
}
