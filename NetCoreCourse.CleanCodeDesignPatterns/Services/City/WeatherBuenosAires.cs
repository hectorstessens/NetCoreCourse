namespace NetCoreCourse.CleanCodeDesignPatterns.Services.City
{
    public class WeatherBuenosAires : IWeather
    {
        public WeatherForecast Get()
        {
            return new WeatherForecast()
            {
                 Date = DateTime.Now,
                 TemperatureC = 32
            };
        }
    }
}
