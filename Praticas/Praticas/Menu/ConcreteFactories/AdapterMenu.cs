using Praticas.Adapters;
using Praticas.Menu.Abstractions;
using Praticas.Targets;

namespace Praticas.Menu.ConcreteFactories
{
    public class AdapterMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Processar mensalidade");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var students = new string[4, 4]
                {
                    { Guid.NewGuid().ToString(), "João", "Matemática", "100" },
                    { Guid.NewGuid().ToString(), "Maria", "Física", "200" },
                    { Guid.NewGuid().ToString(), "Joana", "Português", "300" },
                    { Guid.NewGuid().ToString(), "José", "Química", "400" }
                };

                Console.WriteLine("Processando mensalidade...");

                IHighSchoolStudentTarget studentAdapter = new HighSchoolStudentAdapter();
                studentAdapter.ProcessMonthlyFee(students);

                Console.WriteLine("Mensalidades processadas!");
                Console.ReadKey();
            });
        }
    }
}
