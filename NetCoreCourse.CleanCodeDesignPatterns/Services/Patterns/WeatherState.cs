namespace NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns
{
    public interface IClimaState
    {
        string Reporte();
    }

    public class ClimaSeguro : IClimaState
    {
        public string Reporte()
        {
         return "Las condiciones climáticas son seguras para circular.";
        }
    }

    public class ClimaPeligroso : IClimaState
    {
        public string Reporte()
        {
            return  "Es peligroso circular en estas condiciones climáticas.";
        }
    }

    // Contexto que utiliza el patrón State
    public class CondicionesClimaticas
    {
        private IClimaState estado;

        public CondicionesClimaticas(IClimaState estadoInicial)
        {
            estado = estadoInicial;
        }

        public void CambiarEstado(IClimaState nuevoEstado)
        {
            estado = nuevoEstado;
        }

        public string MostrarMensajeDeCirculacion()
        {
           return estado.Reporte();
        }
    }
}
