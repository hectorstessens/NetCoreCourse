namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{

    public interface IWeatherForeCastService
    {
        Task<WeatherForecast> GetWeatherForecast(string city);
    }

    public class WeatherForeCastService : IWeatherForeCastService
    {
        private readonly IWeatherForeCastFactory weatherForeCastFactory;

        public WeatherForeCastService(IWeatherForeCastFactory weatherForeCastFactory)
        {
            this.weatherForeCastFactory = weatherForeCastFactory;
        }
        public async Task<WeatherForecast> GetWeatherForecast(string city)
        {
            var weather = await weatherForeCastFactory.Create(city);

            return weather.Get();
        }
    }
}