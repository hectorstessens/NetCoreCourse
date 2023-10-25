namespace NetCoreCourse.CleanCodeDesignPatterns.Services.City
{
    public class WeatherRosario : IWeather
    {
        public WeatherForecast Get()
        {
            return new WeatherForecast()
            {
                Date = DateTime.Now,
                TemperatureC = 33
            };
        }
    }
}
