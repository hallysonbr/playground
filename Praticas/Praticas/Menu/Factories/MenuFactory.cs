using Praticas.Menu.ConcreteFactories;
using Praticas.Menu.Interfaces;

namespace Praticas.Menu.Factories
{
    public static class MenuFactory
    {
        private static Dictionary<char, IMenu> Options = new Dictionary<char, IMenu>
        {
            { '1', new FactoryMenu() },
            { '2', new AbstractFactoryMenu() },
            { '3', new BuilderMenu() },
            { '4', new PrototypeMenu() },
            { '5', new SingletonMenu() },
        };

        public static IMenu GetMenu(char option)
        {
            if (Options.TryGetValue(option, out var menu)) return menu;
           
            throw new ArgumentException("Opção inválida");
        }
    }
}
