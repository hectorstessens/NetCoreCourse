using NetCoreCourse.CleanCodeDesignPatterns.Services.City;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{
    public interface IWeatherForeCastFactory
    {
        Task<IWeather> Create(string cityName);
    }

    public class WeatherForeCastFactory : IWeatherForeCastFactory
    {
        private readonly IServiceProvider serviceProvider;

        public WeatherForeCastFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        private readonly Dictionary<string, Type> factories = new Dictionary<string, Type>
        {
            ["BuenosAires"] = typeof(WeatherBuenosAires),
            ["Rosario"] = typeof(WeatherRosario)
        };

        public async Task<IWeather> Create(string cityName)
        {
            if (this.factories.TryGetValue(cityName, out Type weather))
            {
                return (IWeather) this.serviceProvider.GetService(weather);
            }

            throw new NotSupportedException(cityName);
        }
    }
}
