namespace NetCoreCourse.CleanCodeDesignPatterns.Domain
{
    /// <summary>
    /// Composite Example
    /// </summary>
    public class Provincia
    {
        public string Name { get; set; }
        public List<Ciudad> Ciudades { get; set; }
    }
}
