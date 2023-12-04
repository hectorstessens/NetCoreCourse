using System.Text;

namespace Patterns.Api.Domain
{
    public class ComboBuilder
    {
        private StringBuilder sb = new StringBuilder();
        public ComboBuilder AddHamburguesa()
        {
            sb.Append("Hamburguesa");
            sb.AppendLine();
            return this;
        }

        public ComboBuilder AddQueso()
        {
            sb.Append("Queso");
            sb.AppendLine();
            return this;
        }


        public ComboBuilder AddPepino()
        {
            sb.Append("Pepino");
            sb.AppendLine();
            return this;
        }

        public ComboBuilder AddGaseosa()
        {
            sb.Append("Gaseosa");
            sb.AppendLine();
            return this;
        }

        public ComboBuilder AddPapas()
        {
            sb.Append("Papas");
            sb.AppendLine();
            return this;
        }

        public ComboBuilder AddBacon()
        {
            sb.Append("Bacon");
            sb.AppendLine();
            return this;
        }

        public ComboBuilder AddLechuga()
        {
            sb.Append("Lechuga");
            sb.AppendLine();
            return this;
        }

        public ComboBuilder AddTomate()
        {
            sb.Append("Tomate");
            sb.AppendLine();
            return this;
        }

        public string Cocinar()
        {
            return sb.ToString();
        }
    }
}
