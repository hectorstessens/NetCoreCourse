using NetCoreCourse.CleanCodeDesignPatterns.Services.City;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns
{
    public class TemperaturaDecorator: ITiempo
    {
        protected ITiempo tiempo;

        public TemperaturaDecorator(ITiempo tiempo)
        {
            this.tiempo = tiempo;
        }

        public PronosticoTiempo Get()
        {
            return new PronosticoTiempo() { Date = DateTime.Now.AddDays(1), TemperatureC = 23, Summary = "Nueva Tempratura Decorator" };
        }
    }
}
