using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Mappers;
using API.Modeles;
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
        private AdresseRepository _adRepo;

        public UtilisateurController(UtilisateurRepository utRepo, AdresseRepository adRepo)
        {
            _utRepo = utRepo;
            _adRepo = adRepo;
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

        [HttpGet]
        //[Route("Get")]
        public IActionResult Get()
        {
            List<UserWithAdress> list = _utRepo.Get().Select(x => x.DalToApi()).ToList();
            foreach (UserWithAdress user in list)
            {
                user.Adresse = _adRepo.GetById(user.AdresseId);
            }
            return Ok(list);
        }


        //[HttpGet]
        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            UserWithAdress ut = _utRepo.GetById(Id).DalToApi();
            ut.Adresse = _adRepo.GetById(ut.AdresseId);

            return Ok(ut);

        }




    }
}
