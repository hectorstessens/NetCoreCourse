using Microsoft.AspNetCore.Mvc;

using NetCoreCourse.CleanCodeDesignPatterns.Services;

namespace NetCoreCourse.CleanCodeDesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TerremotoController: ControllerBase
    {
        private readonly ITerremotoService terremotoService;
        public TerremotoController(ITerremotoService terremotoService) 
        {
            this.terremotoService = terremotoService;
        }

        [HttpGet]
        //Use Intention-Revealing Names
        public async Task<double> GetCosas([FromQuery] string cityName)
        {
            return terremotoService.ObtenerEsoQueNecesito(cityName);
        }
    }
}
