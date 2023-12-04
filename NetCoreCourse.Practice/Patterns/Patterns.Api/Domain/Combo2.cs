namespace Patterns.Api.Domain
{
    public class Combo2 : ICombo
    {
        public string GetCombo()
        {
            return new ComboBuilder()
                    .AddHamburguesa()
                    .AddBacon()
                    .AddQueso()
                    .AddGaseosa()
                    .AddPapas()
                    .Cocinar();
        }
    }
}
