using Praticas.Composites;
using Praticas.Leafs;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class CompositeMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Gerar Horas Trabalhadas por Departamento");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var organization = new Organization { Name = "Empresa X" };

                var departamentIT = new Organization { Name = "Departamento de TI" };

                departamentIT.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "João", Hours = 8 });
                departamentIT.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Maria", Hours = 12 });
                departamentIT.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Joana", Hours = 10 });

                var departamentHR = new Organization { Name = "Departamento de RH" };

                departamentHR.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Jessé", Hours = 6 });
                departamentHR.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Alberto", Hours = 9 });
                departamentHR.Add(new WorkingEmployee { Id = Guid.NewGuid(), Name = "Cassia", Hours = 5 });

                organization.Add(departamentIT);
                organization.Add(departamentHR);
                organization.GetWorkingHours();

                Console.ReadKey();
            });
        }
    }
}
