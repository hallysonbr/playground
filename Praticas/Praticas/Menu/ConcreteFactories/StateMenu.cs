using Praticas.Menu.Abstractions;
using Praticas.States;

namespace Praticas.Menu.ConcreteFactories
{
    public class StateMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Iniciar caixa eletrônico");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var atmMachine = new AtmMachine();

                Console.WriteLine($"Iniciando caixa eletrônico. Estado atual: {atmMachine.GetCurrentState().GetType().Name}");

                atmMachine.EnterPin();
                atmMachine.RequestCash();
                atmMachine.EjectCard();
                atmMachine.InsertCard();

                Console.WriteLine();

                atmMachine.EnterPin();
                atmMachine.RequestCash();
                atmMachine.InsertCard();
                atmMachine.EjectCard();

                Console.ReadKey();
            });
        }
    }
}
