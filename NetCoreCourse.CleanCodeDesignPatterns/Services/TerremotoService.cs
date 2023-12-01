using System.Reflection.Metadata.Ecma335;

using NetCoreCourse.CleanCodeDesignPatterns.Services.Patterns;

namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{
    public interface ITerremotoService
    {
        double ObtenerTemperaturaPorCiudad(string city);
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
        public Dictionary<string, double> CiudadesTemperatura = new Dictionary<string, double>()
        {
            { "Rosario" , 10 },
            { "Santa Fe" , 5 },
            { "Mendoza" , 70 },
            { "San Juan " , 70 },
        };

        public double ObtenerTemperaturaPorCiudad(string city)
        {
            return CiudadesTemperatura.GetValueOrDefault(city);


            //return CalculateEarthquakeProbability(1,1,false);
        }

        public double ObtenerTemperaturaPorCiudadDataBase(string city)
        {
            return CiudadesTemperatura.GetValueOrDefault(city);

        }

        //Should be Small!!!
        //Use Descriptive Names​
        //Function Arguments​
        //Flag Arguments​


        public double CalculateEarthquakeProbability(ParametersTerremoto parametersTerremoto)
        {
            double probability = 0.0;

            if (parametersTerremoto.currentEarthquakeCount == 0)
            {
                if (parametersTerremoto.locationRiskFactor > 5)
                    probability = 0.7;
                else
                    probability = 0.5;

                if (parametersTerremoto.isEarthquakeSeason)
                {
                    probability *= 1.2;
                }
            }
            else if (parametersTerremoto.currentEarthquakeCount == 1)
            {
                if (parametersTerremoto.locationRiskFactor > 5)
                {
                    probability = 0.8;
                }
                else
                {
                    probability = 0.6;
                }

                if (parametersTerremoto.isEarthquakeSeason)
                {
                    probability *= 1.1;
                }
            }
            else if (parametersTerremoto.currentEarthquakeCount == 2)
            {
                if (parametersTerremoto.locationRiskFactor > 5)
                    probability = 0.9;
                else
                    probability = 0.7;

                if (parametersTerremoto.isEarthquakeSeason)
                    probability *= 1.0;
            }
            else if (parametersTerremoto.currentEarthquakeCount >= 3)
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

    public record ParametersTerremoto(int currentEarthquakeCount, int locationRiskFactor, bool isEarthquakeSeason, string city);
}
