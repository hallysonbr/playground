using Praticas.Menu.Abstractions;
using Praticas.Strategies;

namespace Praticas.Menu.ConcreteFactories
{
    public class StrategyMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções para sua viagem:");
            Console.WriteLine("1. Carro Particular");
            Console.WriteLine("2. Táxi");
            Console.WriteLine("3. Avião");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var context = new TrasnportationOptionContext();
                context.DefineStrategy(Option);
                context.ChooseTransportation("João");
            });
        }
    }
}
