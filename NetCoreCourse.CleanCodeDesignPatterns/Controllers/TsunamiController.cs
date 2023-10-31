using Microsoft.AspNetCore.Mvc;

using NetCoreCourse.CleanCodeDesignPatterns.Services;

namespace NetCoreCourse.CleanCodeDesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TsunamiController : ControllerBase
    {
        private readonly ITsunamiService tsunamiService;
        public TsunamiController(ITsunamiService tsunamiService) 
        {
            this.tsunamiService = tsunamiService;
        }

        [HttpGet]
        public async Task<double> GetCosas([FromQuery] string cityName)
        {
            return tsunamiService.ObtenerProbalilidad(cityName);
        }
    }
}
