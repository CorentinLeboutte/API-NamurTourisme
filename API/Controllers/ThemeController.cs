using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public class ThemeController : ControllerBase
    {
        private ThemeRepository _themeRepo;
        private AdresseRepository _adRepo;

        public ThemeController(ThemeRepository themeRepo, AdresseRepository adRepo)
        {
            _themeRepo = themeRepo;
            _adRepo = adRepo;
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
            List<Modeles.ThemeWithAdress> list = _themeRepo.Get().Select(x => x.DalToApi()).ToList();
            foreach (Modeles.ThemeWithAdress theme in list)
            {
                theme.Adresse = _adRepo.GetById(theme.AdresseID);
            }

            return Ok(list);
        }

        [HttpGet]

        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Modeles.ThemeWithAdress theme = _themeRepo.GetById(Id).DalToApi();
            theme.Adresse = _adRepo.GetById(theme.AdresseID);

            return Ok(theme);
        }



    }
}
