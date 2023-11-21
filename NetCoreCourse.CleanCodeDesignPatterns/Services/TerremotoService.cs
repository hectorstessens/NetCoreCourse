using NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{


    public interface ITerremotoService
    {
        double ObtenerEsoQueNecesito(string city);
        double GetProbabilidadTerromotoJapon();
    }
    public class TerremotoService : ITerremotoService
    {
        private readonly IJapanServiceAdapter japanServiceAdapter;
        public TerremotoService(IJapanServiceAdapter japanServiceAdapter) 
        {
            this.japanServiceAdapter = japanServiceAdapter;
        }
        
        //Avoid Disinformation
        public Dictionary<string, double> ListStringDecimalCiudadesConNumeros = new Dictionary<string, double>()
        {
            { "Rosario" , 10 },
            { "Santa Fe" , 5 },
            { "Mendoza" , 70 },
            { "San Juan " , 70 },
        };

        public double ObtenerEsoQueNecesito(string city)
        {
            return ListStringDecimalCiudadesConNumeros.GetValueOrDefault(city);

            //return CalculateEarthquakeProbability(1,1,false);
        }

        //Should be Small!!!
        //Use Descriptive Names​
        //Function Arguments​
        //Flag Arguments​


        public double CalculateEarthquakeProbability(int currentEarthquakeCount, int locationRiskFactor, bool isEarthquakeSeason)
        {
            double probability = 0.0;

            if (currentEarthquakeCount == 0)
            {
                if (locationRiskFactor > 5)
                    probability = 0.7;
                else
                    probability = 0.5;

                if (isEarthquakeSeason)
                {
                    probability *= 1.2;
                }
            }
            else if (currentEarthquakeCount == 1)
            {
                if (locationRiskFactor > 5)
                {
                    probability = 0.8;
                }
                else
                {
                    probability = 0.6;
                }

                if (isEarthquakeSeason)
                {
                    probability *= 1.1;
                }
            }
            else if (currentEarthquakeCount == 2)
            {
                if (locationRiskFactor > 5)
                    probability = 0.9;
                else
                    probability = 0.7;

                if (isEarthquakeSeason)
                    probability *= 1.0;
            }
            else if (currentEarthquakeCount >= 3)
            {
                probability = 1.0;
            }

            return probability;
        }

        public double GetProbabilidadTerromotoJapon()
        {
            return japanServiceAdapter.ProbabilidadTerremoto();
        }
    }
}
