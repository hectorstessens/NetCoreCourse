namespace Patterns.Api.Domain
{
    public interface IComboFactory
    {
        Task<ICombo> Create(int combo);
    }

    public class ComboFactory : IComboFactory
    {
        private readonly IServiceProvider serviceProvider;

        public ComboFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        private readonly Dictionary<int, Type> factories = new Dictionary<int, Type>
        {
            [1] = typeof(Combo1),
            [2] = typeof(Combo2),
            [3] = typeof(Combo3)
        };

        public async Task<ICombo> Create(int combo)
        {
            if (factories.TryGetValue(combo, out Type Combo))
            {
                return (ICombo)serviceProvider.GetService(Combo);
            }

            throw new NotSupportedException(combo.ToString());
        }
    }
}
