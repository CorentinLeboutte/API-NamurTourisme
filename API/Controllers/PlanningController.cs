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
    public class PlanningController : ControllerBase
    {
        private PlanningRepository _planRepo;
        public PlanningController(PlanningRepository planRepo)
        {
            _planRepo = planRepo;
        }

        //CREATE

        [Route("Create")]
        public IActionResult Create([FromBody] Planning planning)
        {
            int success = _planRepo.Create(planning);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }


        //UPDATE

        [Route("Update")]
        public IActionResult Update([FromBody] Planning planning)
        {
            int success = _planRepo.Update(planning);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }

        //DELETE

        [Route("Delete/{Id}")]
        public IActionResult Delete(/*[FromRoute]*/ int Id)
        {
            _planRepo.Delete(Id);
            return Ok();
        }

        //GET

        [HttpGet]
        //[Route("Get")]
        public IActionResult Get()
        {
            IEnumerable<Planning> list = _planRepo.Get();
            return Ok(list);
        }


        //[HttpGet]
        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Planning plan = new Planning();
            plan = _planRepo.GetById(Id);
            return Ok(plan);

        }




    }
}
