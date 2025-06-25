using Praticas.Factories;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class FactoryMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("0. Pessoa Física");
            Console.WriteLine("1. Pessoa Jurídica");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                Console.WriteLine();
                var pessoaService = PessoaFactory.InitPessoa(Option);
                var result = pessoaService.GetPessoa();
                Console.WriteLine(result);
            });
        }
    }
}
