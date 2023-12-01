namespace NetCoreCourse.CleanCodeDesignPatterns.Domain
{
    public class Pais
    {
        public string Nombre { get; protected set; }
        public string Inflacion { get; protected set; }
        public Pais(string nombre,string inflacion) 
        {
            this.Nombre = nombre;
            this.Inflacion = inflacion;
        }

        public static Pais CrearPais(string nombre) 
        {
            string inflacion = string.Empty;
            if (nombre.Equals("Argentina")) inflacion = "200";

            return new Pais("Nombre del Pais: " + nombre, inflacion);
        }

        public List<Provincia> Provincias { get; set; }


        public string GetListaCiudades()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            foreach (var provincia in this.Provincias)
                stringBuilder.Append(provincia.GetCiudades());

            return stringBuilder.ToString();
        }
    }
}
