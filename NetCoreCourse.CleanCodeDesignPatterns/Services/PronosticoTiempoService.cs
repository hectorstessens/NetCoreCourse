using NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{

    public interface IPronosticoTiempoService
    {
        Task<PronosticoTiempo> GetPronosticoTiempoFactory(string city);
    }

    public class PronosticoTiempoService : IPronosticoTiempoService
    {
        private readonly IPronosticoTiempoFactory pronosticoTiempoFactory;

        public PronosticoTiempoService(IPronosticoTiempoFactory pronosticoTiempoFactory)
        {
            this.pronosticoTiempoFactory = pronosticoTiempoFactory;
        }
        public async Task<PronosticoTiempo> GetPronosticoTiempoFactory(string city)
        {
            // Extract Try/Catch Blocks​
            try
            {
                var pronosticoTiempo = await pronosticoTiempoFactory.Create(city);

                var decorator = new TemperaturaDecorator(pronosticoTiempo);
                return decorator.Get();

                //return pronosticoTiempo.Get();
            }
            catch
            {
                return new PronosticoTiempo();
            }
        }
    }
}