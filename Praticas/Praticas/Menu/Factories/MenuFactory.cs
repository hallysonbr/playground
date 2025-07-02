using Praticas.Menu.ConcreteFactories;
using Praticas.Menu.Interfaces;

namespace Praticas.Menu.Factories
{
    public static class MenuFactory
    {
        private static Dictionary<string, IMenu> Options = new Dictionary<string, IMenu>
        {
            { "1", new FactoryMenu() },
            { "2", new AbstractFactoryMenu() },
            { "3", new BuilderMenu() },
            { "4", new PrototypeMenu() },
            { "5", new SingletonMenu() },
            { "6", new AdapterMenu() },
            { "7", new BridgeMenu() },
            { "8", new CompositeMenu() },
            { "9", new DecoratorMenu() },
            { "10", new FacadeMenu() },
            { "11", new FlyweightMenu() },
            { "12", new ProxyMenu() },
            { "13", new ChainOfResponsibilityMenu() },
            { "14", new CommandMenu() },
            { "15", new InterpreterMenu() },
            { "16", new IteratorMenu() },
            { "17", new MediatorMenu() },
        };

        public static IMenu GetMenu(string option)
        {
            if (Options.TryGetValue(option, out var menu)) return menu;
           
            throw new ArgumentException("Opção inválida");
        }
    }
}
