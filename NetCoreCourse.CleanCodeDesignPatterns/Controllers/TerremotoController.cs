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
        public async Task<decimal> GetCosas([FromQuery] string cityName)
        {
            return terremotoService.ObtenerEsoQueNecesito(cityName);
        }
    }
}
