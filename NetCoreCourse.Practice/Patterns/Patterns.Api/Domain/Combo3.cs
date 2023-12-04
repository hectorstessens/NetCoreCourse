namespace Patterns.Api.Domain
{
    public class Combo3 : ICombo
    {
        public string GetCombo()
        {
            return new ComboBuilder()
                    .AddHamburguesa()
                    .AddLechuga()
                    .AddTomate()
                    .AddGaseosa()
                    .Cocinar();
        }
    }
}
