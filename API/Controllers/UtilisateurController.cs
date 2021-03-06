﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Mappers;
using API = API.Modeles;
using DAL.Models;
using DAL.Repository.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API.Modeles;

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
            List<Modeles.UserWithAdress> list = _utRepo.Get().Select(x => x.DalToApiUserWithAdress()).ToList();
            foreach (Modeles.UserWithAdress user in list)
            {
                user.Adresse = _adRepo.GetById(user.AdresseID);
            }
            return Ok(list);
        }


        //[HttpGet]
        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Modeles.UserWithAdress ut = _utRepo.GetById(Id).DalToApiUserWithAdress();
            ut.Adresse = _adRepo.GetById(ut.AdresseID);

            return Ok(ut);

        }




    }
}
