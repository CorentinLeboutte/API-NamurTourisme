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
        private TypeThemeRepository _ttRepo;

        public ThemeController(ThemeRepository themeRepo, AdresseRepository adRepo, TypeThemeRepository ttRepo)
        {
            _themeRepo = themeRepo;
            _adRepo = adRepo;
            _ttRepo = ttRepo;

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
            IEnumerable<Modeles.ThemeLite> theme = _themeRepo.Get().Select(T=>T.DalToApiThemeLite());
            return Ok(theme);
        }

        [HttpGet]

        [Route("GetById/{Id}")]
        public IActionResult GetById(/*[FromRoute]*/ int Id)
        {
            Modeles.ThemeDetailed theme = _themeRepo.GetById(Id).DalToApiThemeDetailed();

            theme.Adresse = _adRepo.GetById(theme.AdresseID);
            theme.TypeTheme = _ttRepo.GetByTheme(theme.ThemeID);


            return Ok(theme);


        }


        [HttpGet]

        [Route("GetByTypeTheme/{Id}")]
        public IActionResult GetByTypeTheme(/*[FromRoute]*/ int Id)
        {
            IEnumerable<Modeles.ThemeLite> themes = _themeRepo.GetByTypeTheme(Id).Select(tt => tt.DalToApiThemeLite());
            /*themes = themes.Select(tt =>
            {
                tt.Adresse = _adRepo.GetById(tt.AdresseID);
                tt.TypeTheme = _ttRepo.GetByTheme(tt.ThemeID);
                return tt;
            });*/
            return Ok(themes);
        }




    }
}
