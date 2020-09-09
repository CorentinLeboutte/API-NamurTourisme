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
    public class AdresseController : ControllerBase
    {

        private AdresseRepository _adRepo;
        public AdresseController(AdresseRepository adRepo)
        {
            _adRepo = adRepo;
        }

        //CREATE

        [Route("Create")]
        public IActionResult Create([FromBody] Adresse adresse)
        {
            int success = _adRepo.Create(adresse);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }


        //UPDATE

        [Route("Update")]
        public IActionResult Update([FromBody] Adresse adresse)
        {
            int success = _adRepo.Update(adresse);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }

        //DELETE

        [Route("Delete/{Id}")]
        public IActionResult Delete(/*[FromRoute]*/ int Id)
        {
            _adRepo.Delete(Id);
            return Ok();
        }

        //GET
        [HttpGet]
        //[Route("Get")]
        public IActionResult Get()
        {
            IEnumerable<Adresse> list = _adRepo.Get();
            return Ok(list);

        }



        //[HttpGet]
        
        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Adresse ad = new Adresse();
            ad = _adRepo.GetById(Id);
            return Ok(ad);

        }
    }
}
