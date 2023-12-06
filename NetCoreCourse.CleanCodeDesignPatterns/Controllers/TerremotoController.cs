using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using NetCoreCourse.CleanCodeDesignPatterns.Domain;
using NetCoreCourse.CleanCodeDesignPatterns.Services;

namespace NetCoreCourse.CleanCodeDesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TerremotoController: ControllerBase
    {
        private readonly ITerremotoService terremotoService;
        public TerremotoController(IMapper mapper, ITerremotoService terremotoService) 
        {
            this.terremotoService = terremotoService;
        }

        [HttpGet]
        //Use Intention-Revealing Names
        public async Task<double> ObtenerTemperaturaPorCiudad([FromQuery] string cityName)
        {
            return terremotoService.ObtenerTemperaturaPorCiudad(cityName);
        }
        /// <summary>
        /// Este metodo devuelve la probabilidad de un terremoto en japon
        /// </summary>
        /// <returns></returns>
        [HttpGet("ProbabilidadTerromotoJapon")]
        public async Task<double> GetProbabilidadTerromotoJapon() 
        {

            Pais pais = Pais.CrearPais("Francia");

            return terremotoService.GetProbabilidadTerromotoJapon();
        }
    }
}
