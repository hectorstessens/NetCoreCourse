using Microsoft.AspNetCore.Mvc;

using NetCoreCourse.CleanCodeDesignPatterns.Services;

namespace NetCoreCourse.CleanCodeDesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PronosticoTiempoController : ControllerBase
    {
        private readonly IPronosticoTiempoService pronosticoTiempoService;

        public PronosticoTiempoController(IPronosticoTiempoService pronosticoTiempoService)
        {
            this.pronosticoTiempoService = pronosticoTiempoService;
        }

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };


        [HttpGet("GetWeatherForecast")]
        public IEnumerable<PronosticoTiempo> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new PronosticoTiempo
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("GetWeatherForecastByCity")]
        public async Task<PronosticoTiempo> GetByCity([FromQuery] string cityName)
        {
            return await pronosticoTiempoService.GetPronosticoTiempoFactory(cityName);
        }
    }
}