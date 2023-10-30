namespace NetCoreCourse.CleanCodeDesignPatterns.Services.City
{
    public class TiempoBuenosAires : ITiempo
    {
        public PronosticoTiempo Get()
        {
            return new PronosticoTiempo()
            {
                 Date = DateTime.Now,
                 TemperatureC = 32
            };
        }
    }
}
