using NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{
    public interface ITransitoService
    {
        string MostrarMensajeDeCirculacion();
    }

    public class TransitoService : ITransitoService
    {
        public string MostrarMensajeDeCirculacion() 
        {
            // Crear instancias de los estados
            var climaSeguro = new ClimaSeguro();
            var climaPeligroso = new ClimaPeligroso();

            // Crear instancia del contexto
            var condicionesClimaticas = new CondicionesClimaticas(climaSeguro);

            // Mostrar mensaje inicial
            condicionesClimaticas.MostrarMensajeDeCirculacion();

            // Cambiar a condiciones peligrosas
            condicionesClimaticas.CambiarEstado(climaPeligroso);

            // Mostrar mensaje con condiciones peligrosas
            return condicionesClimaticas.MostrarMensajeDeCirculacion();
        }
    }
}
