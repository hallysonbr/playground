using Praticas.ConcreteImplementors;
using Praticas.Menu.Abstractions;
using Praticas.Models;
using Praticas.RefinedAbstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class BridgeMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Gravar Arquivo json");
            Console.WriteLine("2. Gravar Arquivo xml");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                CalculateSalary calculateSalary;

                switch (Option)
                {
                    case '1':
                        calculateSalary = new CalculateSalary(new WriteJson());
                        break;
                    case '2':
                        calculateSalary = new CalculateSalary(new WriteXml());
                        break;
                    default:
                        calculateSalary = new CalculateSalary(new WriteJson());
                        break;
                }

                var employee = new Employee
                {
                    Id = Guid.NewGuid(),
                    Name = "João",
                    BaseSalary = 1000,
                    Gratification = Option == '1' ? 700 : 800
                };

                calculateSalary.ProcessSalary(employee);

                Console.ReadKey();
            });
        }
    }
}
