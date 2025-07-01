using Praticas.ConcretePrototypes;
using Praticas.Menu.Abstractions;

namespace Praticas.Menu.ConcreteFactories
{
    public class PrototypeMenu : MenuItem
    {
        public override bool ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("1. Soldado");
            Console.WriteLine("9. Sair");

            return ExecuteMenu(() =>
            {
                var soldier = new Soldier();
                soldier.Name = "Soldier Boy";
                soldier.Gun = "AK-47";
                soldier.Acessory = new Acessory { Name = "Óculos de visão noturna " };

                var clone1 = (Soldier)soldier.Clone();
                clone1.Name = "Soldier Clone 1";
                clone1.Gun = "Desert Eagle";
                clone1.Acessory.Name = "Colete à prova de balas";

                var clone2 = (Soldier)soldier.Clone();
                clone2.Name = "Soldier Clone 2";
                clone2.Gun = "M4A1";
                clone2.Acessory.Name = "Coquetel Molotov";

                Console.WriteLine("Shallow Copy");

                Console.WriteLine("Soldado Original");
                Console.WriteLine($"Nome: {soldier.Name} - Arma: {soldier.Gun} - Acessório: {soldier.Acessory.Name}");

                Console.WriteLine("Clone 1");
                Console.WriteLine($"Nome: {clone1.Name} - Arma: {clone1.Gun} - Acessório: {clone1.Acessory.Name}");

                Console.WriteLine("Clone 2");
                Console.WriteLine($"Nome: {clone2.Name} - Arma: {clone2.Gun} - Acessório: {clone2.Acessory.Name}");

                soldier.Acessory = new Acessory { Name = "Óculos de visão noturna " };

                clone1 = (Soldier)soldier.DeepClone();
                clone1.Name = "Soldier Clone 1";
                clone1.Gun = "Desert Eagle";
                clone1.Acessory.Name = "Colete à prova de balas";

                clone2 = (Soldier)soldier.DeepClone();
                clone2.Name = "Soldier Clone 2";
                clone2.Gun = "M4A1";
                clone2.Acessory.Name = "Coquetel Molotov";

                Console.WriteLine("Deep Copy");

                Console.WriteLine("Soldado Original");
                Console.WriteLine($"Nome: {soldier.Name} - Arma: {soldier.Gun} - Acessório: {soldier.Acessory.Name}");

                Console.WriteLine("Clone 1");
                Console.WriteLine($"Nome: {clone1.Name} - Arma: {clone1.Gun} - Acessório: {clone1.Acessory.Name}");

                Console.WriteLine("Clone 2");
                Console.WriteLine($"Nome: {clone2.Name} - Arma: {clone2.Gun} - Acessório: {clone2.Acessory.Name}");

                Console.ReadKey();
            });
        }
    }
}
