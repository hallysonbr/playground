using Praticas.Menu.Abstractions;
using Praticas.Utils;

namespace Praticas.Menu.ConcreteFactories
{
    public class PalindromeMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== VERIFICADOR DE PALÍNDROMO ===");
            Console.WriteLine("1. Verificar se uma string é palíndromo");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                Console.WriteLine("\nDigite a string para verificar se é um palíndromo:");
                string? input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("❌ Entrada inválida!");
                    return;
                }

                string? result = PalindromeChecker.GetPalindromeIfValid(input);

                if (result != null)
                {
                    Console.WriteLine($"✅ '{result}' É UM PALÍNDROMO!");
                }
                else
                {
                    Console.WriteLine($"❌ '{input}' NÃO é um palíndromo!");
                }
            });
        }
    }
}
