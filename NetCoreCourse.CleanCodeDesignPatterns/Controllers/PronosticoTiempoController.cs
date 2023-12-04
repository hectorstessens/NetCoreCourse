using Microsoft.AspNetCore.Mvc;

using NetCoreCourse.CleanCodeDesignPatterns.Services;

namespace NetCoreCourse.CleanCodeDesignPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PronosticoTiempoController : ControllerBase
    {
        private readonly IPronosticoTiempoService pronosticoTiempoService;
        private readonly ITransitoService transitoService;
        private readonly ICalculoHumedadService calculoHumedadService;

        public PronosticoTiempoController(IPronosticoTiempoService pronosticoTiempoService, ITransitoService transitoService, ICalculoHumedadService calculoHumedadService)
        {
            this.pronosticoTiempoService = pronosticoTiempoService;
            this.transitoService = transitoService;
            this.calculoHumedadService = calculoHumedadService;
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

        [HttpGet("GetTransito")]
        public async Task<string> GetTransito()
        {
            return transitoService.MostrarMensajeDeCirculacion();
        }

        [HttpGet("GetHumedad")]
        public async Task<string> GetHumedad()
        {
            return calculoHumedadService.GetHumedad();
        }
    }
}