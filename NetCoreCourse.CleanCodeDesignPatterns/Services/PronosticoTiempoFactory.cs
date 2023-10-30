using NetCoreCourse.CleanCodeDesignPatterns.Services.City;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
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
            if (this.factories.TryGetValue(cityName, out Type weather))
            {
                return (ITiempo) this.serviceProvider.GetService(weather);
            }

            throw new NotSupportedException(cityName);
        }
    }
}
