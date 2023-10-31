using NetCoreCourse.CleanCodeDesignPatterns.Services.City;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns
{
    public interface IPronosticoTiempoFactory
    {
        Task<ITiempo> Create(string cityName);
    }

    public class PronosticoTiempoFactory : IPronosticoTiempoFactory
    {
        private readonly IServiceProvider serviceProvider;

        public PronosticoTiempoFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        private readonly Dictionary<string, Type> factories = new Dictionary<string, Type>
        {
            ["BuenosAires"] = typeof(TiempoBuenosAires),
            ["Rosario"] = typeof(TiempoRosario)
        };

        public async Task<ITiempo> Create(string cityName)
        {
            if (factories.TryGetValue(cityName, out Type weather))
            {
                return (ITiempo)serviceProvider.GetService(weather);
            }

            throw new NotSupportedException(cityName);
        }
    }
}
