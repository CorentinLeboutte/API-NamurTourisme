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
    public class AvisController : ControllerBase
    {
        private AvisRepository _avRepo;

        public AvisController(AvisRepository avRepo)
        {
            _avRepo = avRepo;
        }

        //CREATE

        //[Route("Create")]
        [HttpPut]
        public IActionResult Create([FromBody] Avis avis)
        {
            int success = _avRepo.Create(avis);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }


        //UPDATE
        [HttpPut]
        public IActionResult Update([FromBody] Avis avis)
        {
            int success = _avRepo.Update(avis);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }

        //DELETE

        [HttpPut("{Id}")]
        //[Route("Delete/{Id}")]
        public IActionResult Delete(/*[FromRoute]*/ int Id)
        {
            _avRepo.Delete(Id);
            return Ok();
        }

        //GET

        [HttpGet]
        //[Route("Get")]
        public IActionResult Get()
        {
            IEnumerable<Avis> list = _avRepo.Get();
            return Ok(list);
        }


        [HttpGet("{Id}")]
        //[Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Avis av = new Avis();
            av = _avRepo.GetById(Id);
            return Ok(av);

        }




    }
}
