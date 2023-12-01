namespace NetCoreCourse.CleanCodeDesignPatterns.Services.City
{
    public class TiempoTokio : ITiempo
    {
        public PronosticoTiempo Get()
        {
            return new PronosticoTiempo()
            {
                 Date = DateTime.Now,
                 TemperatureC = 8
            };
        }
    }
}
