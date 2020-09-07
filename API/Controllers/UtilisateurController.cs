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
    public class UtilisateurController : ControllerBase
    {
        private UtilisateurRepository _utRepo;

        public UtilisateurController(UtilisateurRepository utRepo)
        {
            _utRepo = utRepo;
        }

        //CREATE

        [Route("Create")]
        public IActionResult Create([FromBody] Utilisateur utilisateur)
        {
            int success = _utRepo.Create(utilisateur);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }


        //UPDATE

        [Route("Update")]
        public IActionResult Update([FromBody] Utilisateur utilisateur)
        {
            int success = _utRepo.Update(utilisateur);
            if (success == 0)
                return Ok();
            else
                return NotFound();
        }

        //DELETE

        [Route("Delete/{Id}")]
        public IActionResult Delete(/*[FromRoute]*/ int Id)
        {
            _utRepo.Delete(Id);
            return Ok();
        }

        //GET

        [Route("Get")]
        public IActionResult Get()
        {
            IEnumerable<Utilisateur> list = _utRepo.Get();
            return Ok(list);
        }

        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Utilisateur ut = new Utilisateur();
            ut = _utRepo.GetById(Id);
            return Ok(ut);

        }




    }
}
