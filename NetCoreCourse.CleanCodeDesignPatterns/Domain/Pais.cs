namespace NetCoreCourse.CleanCodeDesignPatterns.Domain
{
    public class Pais
    {
        public List<Provincia> Provincias { get; set;}


        public string GetListaCiudades()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var provincia in this.Provincias)
            {
                foreach (var ciudad in provincia.Ciudades)    
                stringBuilder.Append(ciudad.Name.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
