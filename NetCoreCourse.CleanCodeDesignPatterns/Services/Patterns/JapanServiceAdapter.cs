using NetCoreCourse.CleanCodeDesignPatterns.Client;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns
{
    public interface IJapanServiceAdapter
    {
        double ProbabilidadTerremoto();
    }
    public class JapanServiceAdapter : IJapanServiceAdapter
    {
        public double ProbabilidadTerremoto()
        {
            try
            {
                JapanWeatherClient.Login();
                JapanWeatherClient.SetConfiguration();
                JapanWeatherClient.SetParameters();

                double probability = JapanWeatherClient.GetProbability();
                return probability;
            }
            catch
            {
                throw new Exception("Servicio no disponible");
            }
      
        }
    }
}
