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
            JapanWeatherClient.Login();

            JapanWeatherClient.SetParameters();

            JapanWeatherClient.SetConfiguration();
            double probability = JapanWeatherClient.GetProbability();
            return probability;
        }
    }
}
