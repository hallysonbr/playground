using Praticas.Mementos;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class MementoMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Calcular a soma de dois números e armazenar o estado");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                Console.WriteLine("Calculando a soma de dois números e armazenando o estado...");

                var calculator = new Calculator();
                calculator.SetFirstNumber(10);
                calculator.SetSecondNumber(20);

                Console.WriteLine($"Estado 1: {calculator.GetCalculationResult()}");

                var memento = calculator.BackupLastCalculation();

                Console.WriteLine("Calculando a soma de dois números e armazenando o estado...");

                calculator.SetFirstNumber(30);
                calculator.SetSecondNumber(40);

                Console.WriteLine($"Estado 2: {calculator.GetCalculationResult()}");

                Console.WriteLine("Restaurando o estado anterior...");

                calculator.RestoreLastCalculation(memento);

                Console.WriteLine($"Estado restaurado: {calculator.GetCalculationResult()}");
                Console.ReadKey();
            });
        }
    }
}
