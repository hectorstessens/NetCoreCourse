using NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{


    public interface ITsunamiService
    {
        double ObtenerProbalilidad(string city);
    }

    public class TsunamiService : ITsunamiService
    {
        private Dictionary<string, CityData> cityData = new Dictionary<string, CityData>() 
        {
            {"Rosario", new CityData(1,2,2) },
            {"Buenos Aires", new CityData(2,4,2.8) },
        };
        private readonly TsunamiProbabilityCalculatorBuilder tsunamiProbabilityCalculatorBuilder;
        public TsunamiService(TsunamiProbabilityCalculatorBuilder tsunamiProbabilityCalculatorBuilder)
        {
            this.tsunamiProbabilityCalculatorBuilder = tsunamiProbabilityCalculatorBuilder;
        }
        public double ObtenerProbalilidad(string city)
        {
            var  result = cityData.FirstOrDefault(m => m.Key == city);
            tsunamiProbabilityCalculatorBuilder.SetHistoricalEvents(result.Value.HistoricalEvents);
            tsunamiProbabilityCalculatorBuilder.SetSeismicActivity(result.Value.SeismicActivity);
            tsunamiProbabilityCalculatorBuilder.SetOceanographicData(result.Value.OceanographicData);

            return tsunamiProbabilityCalculatorBuilder.Build();
        }
    }

    public record CityData(int HistoricalEvents, int SeismicActivity, double OceanographicData);
}
