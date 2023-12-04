using NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{

    public interface ICalculoHumedadService
    {
        string GetHumedad();
    }

    public class CalculoHumedadService : ICalculoHumedadService
    {
        public string GetHumedad()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var calculadoraHumedad = new CalculadoraHumedad();

            // Calcular sensación de humedad con la estrategia de humedad baja
            var resultadoHumedadBaja = calculadoraHumedad.CalcularHumedadParaHumedadRelativa(25);
            stringBuilder.Append($"Resultado (Baja): {resultadoHumedadBaja}");

            // Cambiar a la estrategia de humedad moderada
            calculadoraHumedad.CambiarEstrategia("Moderada");

            // Calcular sensación de humedad con la estrategia de humedad moderada
            var resultadoHumedadModerada = calculadoraHumedad.CalcularHumedadParaHumedadRelativa(35);
            stringBuilder.Append($"Resultado (Moderada): {resultadoHumedadModerada}");

            // Intentar cambiar a una estrategia inexistente
            //calculadoraHumedad.CambiarEstrategia("Inexistente");

            return stringBuilder.ToString();
        }
    }
}
