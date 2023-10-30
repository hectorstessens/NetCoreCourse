namespace NetCoreCourse.CleanCodeDesignPatterns.Services
{

   
    public interface ITerremotoService 
    {
        Decimal ObtenerEsoQueNecesito(string city);
    }
    public class TerremotoService : ITerremotoService
    {
        public Dictionary<string, decimal> List = new Dictionary<string, decimal>()
        {
            { "Rosario" , 10 },
            { "Santa Fe" , 5 },
            { "Mendoza" , 70 },
            { "San Juan " , 70 },            
        };
        public decimal ObtenerEsoQueNecesito(string city)
        {
            return List.GetValueOrDefault(city);
        }
    }
}
