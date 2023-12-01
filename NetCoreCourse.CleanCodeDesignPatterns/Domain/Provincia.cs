using System.Text;

namespace NetCoreCourse.CleanCodeDesignPatterns.Domain
{
    /// <summary>
    /// Composite Example
    /// </summary>
    public class Provincia
    {
        public string Name { get; set; }
        public List<Ciudad> Ciudades { get; set; }

        public string GetCiudades() 
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var ciudad in Ciudades)
                stringBuilder.Append(ciudad.Name.ToString());

            return stringBuilder.ToString();
        }
    }
}
