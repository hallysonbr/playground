using Praticas.Facades;
using Praticas.Menu.Abstractions;
using Praticas.Subsystems;

namespace Praticas.Menu.ConcreteFactories
{
    public class FacadeMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Conceder Emprestimo");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var loan = new GrantLoanFacade();
                var client = new Client("João");

                var result = loan.GrantLoan(client, 1500000.00);

                Console.WriteLine($"The loan requested for {client.Name} was {(result ? "Approved" : "Rejected")}");
                Console.ReadKey();
            });
        }
    }
}
