using Praticas.Commands;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class CommandMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Fazer pedido.");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var chef = new Chef();

                var order = new Order(chef, "Meal");
                var waiter = new Waiter(order);
                waiter.Execute();

                order = new Order(chef, "Dessert");
                waiter = new Waiter(order);
                waiter.Execute();

                Console.ReadKey();
            });
        }
    }
}
