namespace NetCoreCourse.CleanCodeDesignPatterns.Services.City
{
    public class TiempoRosario : ITiempo
    {
        public PronosticoTiempo Get()
        {
            return new PronosticoTiempo()
            {
                Date = DateTime.Now,
                TemperatureC = 33
            };
        }
    }
}
