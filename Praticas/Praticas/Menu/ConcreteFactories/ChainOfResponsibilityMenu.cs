using Praticas.ConcreteHandlers;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class ChainOfResponsibilityMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Solicitar dias de licença.");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() => 
            {
                ProjectManager projectManager = new();
                TeamSupervisor teamSupervisor = new();
                HRDepartment hRDepartment = new();

                projectManager
                    .SetNext(teamSupervisor)
                    .SetNext(hRDepartment);

                projectManager.Handle("Ana", 5);
                projectManager.Handle("João", 10);
                projectManager.Handle("Maria", 20);
                projectManager.Handle("Alberto", 40);

                Console.ReadKey();
            });
        }
    }
}
